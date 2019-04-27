using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using netcoreauth.api.DataStore;
using netcoreauth.model;
using Newtonsoft.Json;

namespace netcoreauth.api.Repository
{

  public class DropDownModel
  {
    public string Name { get; set; }
    public string Code { get; set; }
    public int Id { get; set; }
  }

  public class TrainRepository : ITrainRepository
  {
    public List<DropDownModel> GetCities()
    {
      var list = TrainDataStore.TrainList;
      List<string> from = list.Select(x => x.From).Distinct().ToList();
      List<string> to = list.Select(x => x.To).Distinct().ToList();
      List<string> inbetween = list.SelectMany(x => x.InBetweenStations.Select(y => y.Name)).Distinct().ToList();
      foreach (var item in from)
      {
        if (!inbetween.Contains(item))
          inbetween.Add(item);
      }
      foreach (var item in to)
      {
        if (!inbetween.Contains(item))
          inbetween.Add(item);
      }
      return ReturnListInDropDownModel(inbetween.Select(x => x).Distinct().ToList());
    }

    public List<DropDownModel> ReturnListInDropDownModel(List<string> inbetween)
    {
      List<DropDownModel> dropDownList = new List<DropDownModel>();

      dropDownList.Add(new DropDownModel { Name = "Select Station", Code = null });

      int count = 1;
      foreach (string station in inbetween)
      {
        dropDownList.Add(new DropDownModel { Name = station, Code = Convert.ToString(count++) });
      }
      return dropDownList;
    }

    public bool GetTrainStatus(Train x)
    {
      if ((x.DepartHrs - Convert.ToInt32(DateTime.Now.Hour)) < 0)
      {
        return false;
      }
      else
      {
        if ((x.DepartMin - Convert.ToInt32(DateTime.Now.Minute)) < 0)
        {
          return false;
        }
      }
      return true;
    }

    public bool GetTrainStatusInBetStation(Train x)
    {
      if ((x.InBetweenStations.Select(y => y.DepartHrs).FirstOrDefault() - Convert.ToInt32(DateTime.Now.Hour)) < 0)
      {
        return false;
      }
      else
      {
        if ((x.InBetweenStations.Select(y => y.DepartMin).FirstOrDefault() - Convert.ToInt32(DateTime.Now.Minute)) < 0)
        {
          return false;
        }
      }
      return true;
    }

    public List<Train> GetTrains(string from, string to)
    {
      //if (string.IsNullOrEmpty(from))
      //{
      //  if (string.IsNullOrEmpty(to))
      //  {
      //    
      //    var data = TrainDataStore.TrainList.Where(x => this.GetTrainStatus(x)).ToList();
      //    foreach(var item in data)
      //    {
      //      item.Prediction.FirstOrDefault().Accuracy = this.GetPrediction(item.TrainType, 0.33, ); 
      //    }
      //  }
      //  else
      //  {
      //    var list = TrainDataStore.TrainList;
      //    return list.Where(x => x.To.ToLower().Equals(to.ToLower()) ||
      //                            x.InBetweenStations.Any(y => y.Name.ToLower().Equals(to.ToLower()))).Where(x => this.GetTrainStatus(x) && this.GetTrainStatusInBetStation(x)).ToList();
      //  }
      //}
      //else
      //{
      //  if (string.IsNullOrEmpty(to))
      //  {
      //    var list = TrainDataStore.TrainList;
      //    return list.Where(x => x.From.ToLower().Equals(from.ToLower()) ||
      //                    x.InBetweenStations.Any(y => y.Name.ToLower().Equals(from.ToLower()))).Where(x => this.GetTrainStatus(x) && this.GetTrainStatusInBetStation(x)).ToList();
      //  }
      //  else
      //  {

        Random random = new Random();
        var list = TrainDataStore.TrainList;
        var data = list.Where(x => x.From.ToLower().Equals(from.ToLower()) || x.InBetweenStations.Any(y => y.Name.ToLower().Equals(from.ToLower())) && x.To.ToLower().Equals(to.ToLower()) || x.InBetweenStations.Any(y => y.Name.ToLower().Equals(to.ToLower()))).ToList();
        foreach (var item in data)
        {
          if (item.From == from)
          {
            item.Prediction.FirstOrDefault().Accuracy = this.GetPrediction(item.TrainType, 0.33, 0.06, random.Next(0, 4), item.DepartHrs);
          }
          else
          {
            int index = item.InBetweenStations.FindIndex(a => a.Name == from);
            for (int i = index; i < item.InBetweenStations.Count(); i++)
            {
              item.InBetweenStations[i].Accuracy = this.GetPrediction(item.TrainType, 0.66, 0.18, random.Next(0, 4), item.InBetweenStations[i].DepartHrs);
            }
          }
        }
        return data;
      //  }
      //}
    }

    public int GetPrediction(double traintype, double isHoliday, double seatsVacant, int delay, int arrival)
    {
      int responseString = 0;
      using (var client = new HttpClient())
      {
        try
        {
          //Random random = new Random();
          //= random.Next(10, 30);
          client.BaseAddress = new Uri("http://localhost:5000");
          client.DefaultRequestHeaders.Accept.Clear();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
          var response = client.GetAsync($"/predict?trainType={traintype}&isHoliday={isHoliday}&seatsVacant={seatsVacant}&delay={delay}&arrival={arrival}").Result;
          if (response.IsSuccessStatusCode)
          {
            responseString = Convert.ToInt32(response.Content.ReadAsStringAsync().Result);
            //var modelObject = response.Content.ReadAsAsync<Student>().Result;
          }
          return responseString;
        }
        catch (Exception ex)
        {
          Random rnd = new Random();
          return responseString = rnd.Next(10, 30);
        }        
      }
    }

    public List<PassengerModel> GetPassengers(int trainNumber, int bogiId)
    {
      List<PassengerModel> passengers = TrainDataStore.Passengers;
      List<PassengerModel> sortedPassengers = new List<PassengerModel>();
      if (bogiId == 0)
      {
        sortedPassengers = passengers.Where(x => x.TrainNumber == trainNumber).ToList();
      }
      else
      {
        sortedPassengers = passengers.Where(x => x.TrainNumber == trainNumber && x.BogiId == bogiId).ToList();
      }
      return sortedPassengers;
    }

    public bool UpdatePassengerPresentStatus(PassengerModel data)
    {
      try
      {
        PassengerModel passenger = TrainDataStore.Passengers.Where(x => x.Id == data.Id).FirstOrDefault();

        int index = TrainDataStore.Passengers.IndexOf(passenger);
        passenger.IsPresent = data.IsPresent;

        TrainDataStore.Passengers[index] = passenger;
        return true;
      }
      catch (Exception)
      {
        return false;

      }

    }

    public PassengerModel ReplacePassenger(ReplacePassengerModel rModel)
    {

      PassengerModel passnger = TrainDataStore.Passengers.Where(x => x.Id == rModel.PassengerModel.Id).FirstOrDefault();

      int index = TrainDataStore.Passengers.IndexOf(passnger);

      PassengerModel newPassnger = rModel.PassengerModel;

      passnger.IsReplaced = true;
      TrainDataStore.Passengers[index] = passnger;

      newPassnger.Id = GetPassengerId();
      newPassnger.Name = rModel.NewPassengerName;
      newPassnger.IsPresent = true;
      newPassnger.IsReplaced = false;
      TrainDataStore.Passengers.Insert(index + 1, newPassnger);

      return newPassnger;
    }

    public int GetPassengerId()
    {
      int lastIndex = TrainDataStore.Passengers.Count() + 1;

      bool findUniqueId = false;

      PassengerModel passenger = new PassengerModel();
      while (!findUniqueId)
      {
        passenger = TrainDataStore.Passengers.Where(x => x.Id == lastIndex).FirstOrDefault();
        if (passenger == null)
        {
          findUniqueId = true;
        }
        else
        {
          lastIndex += 1;
        }
      }

      return lastIndex;
    }


  }

}

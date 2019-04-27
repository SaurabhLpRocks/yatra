using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public List<DropDownModel>  GetCities(string search)
    {
      var list = TrainDataStore.TrainList;
      List<string> from = list.Select(x => x.From).Distinct().ToList();
      List<string> to = list.Select(x => x.To).Distinct().ToList();
      List<string> inbetween = list.Select(x => x.InBetweenStations.Select(y => y.Name).FirstOrDefault()).Distinct().ToList();
      foreach (var item in from)
      {
        inbetween.Add(item);
      }
      foreach (var item in to)
      {
        inbetween.Add(item);
      }
      
      if (string.IsNullOrEmpty(search))
      {
        return ReturnListInDropDownModel(inbetween.Select(x => x).Distinct().ToList());
      }
      else
      {
        return ReturnListInDropDownModel(inbetween.Where(x => x.ToLower().StartsWith(search.ToLower())).Distinct().ToList());
      }
    }

    public List<DropDownModel> ReturnListInDropDownModel(List<string> inbetween)
    {
      List<DropDownModel> dropDownList = new List<DropDownModel>();

      dropDownList.Add(new DropDownModel { Name = "Select Station", Code = null});

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
      if (string.IsNullOrEmpty(from))
      {
        if (string.IsNullOrEmpty(to))
        {
          return TrainDataStore.TrainList.Where(x => this.GetTrainStatus(x)).ToList();
        }
        else
        {
          var list = TrainDataStore.TrainList;
          return list.Where(x => x.To.ToLower().Equals(to.ToLower()) ||
                                  x.InBetweenStations.Any(y => y.Name.ToLower().Equals(to.ToLower()))).Where(x => this.GetTrainStatus(x) && this.GetTrainStatusInBetStation(x)).ToList();
        }
      }
      else
      {
        if (string.IsNullOrEmpty(to))
        {
          var list = TrainDataStore.TrainList;
          return list.Where(x => x.From.ToLower().Equals(from.ToLower()) ||
                          x.InBetweenStations.Any(y => y.Name.ToLower().Equals(from.ToLower()))).Where(x => this.GetTrainStatus(x) && this.GetTrainStatusInBetStation(x)).ToList();
        }
        else
        {
          var list = TrainDataStore.TrainList;
          return list.Where(x => x.From.ToLower().Equals(from.ToLower()) || x.InBetweenStations.Any(y => y.Name.ToLower().Equals(from.ToLower())) && x.To.ToLower().Equals(to.ToLower()) || x.InBetweenStations.Any(y => y.Name.ToLower().Equals(to.ToLower()))).Where(x => this.GetTrainStatus(x) && this.GetTrainStatusInBetStation(x)).ToList();
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
  }
}

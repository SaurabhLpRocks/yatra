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
  public class TrainRepository : ITrainRepository
  {
    public List<string> GetCities(string search)
    {
      var list = TrainDataStore.TrainList;
      List<string> from = list.Select(x => x.From).Distinct().ToList();
      List<string> to = list.Select(x => x.To).Distinct().ToList();
      List<string> inbetween = list.Select(x => x.InBetweenStations.Select(y => y).FirstOrDefault()).Distinct().ToList();
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
        return inbetween.Select(x => x).Distinct().ToList();
      }
      else
      {
        return inbetween.Where(x => x.ToLower().StartsWith(search.ToLower())).Distinct().ToList();
      }
    }

    public List<Train> GetTrains(string from, string to)
    {
      if (string.IsNullOrEmpty(from))
      {
        if (string.IsNullOrEmpty(to))
        {
          return TrainDataStore.TrainList;
        }
        else
        {
          var list = TrainDataStore.TrainList;
          return list.Where(x => x.To.ToLower().Equals(to.ToLower())).ToList();
        }
      }
      else
      {
        if (string.IsNullOrEmpty(to))
        {
          var list = TrainDataStore.TrainList;
          return list.Where(x => x.From.ToLower().Equals(from.ToLower())).ToList();
        }
        else
        {
          var list = TrainDataStore.TrainList;
          return list.Where(x => x.From.ToLower().Equals(from.ToLower()) && x.To.ToLower().Equals(to.ToLower())).ToList();
        }
      }
      return null;
    }
  }
}

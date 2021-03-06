using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netcoreauth.api.DataStore;
using netcoreauth.api.Repository;
using netcoreauth.model;

namespace netcoreauth.api.Business
{
  public interface ITrainService
  {
    List<Train> GetTrains(string from, string to);
    List<DropDownModel> GetCities();
    List<PassengerModel> GetPassengers(int trainNumber, int bogiId);

    bool UpdatePassengerPresentStatus(PassengerModel data);

    PassengerModel ReplacePassenger(ReplacePassengerModel rModel);

  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netcoreauth.api.DataStore;
using netcoreauth.model;

namespace netcoreauth.api.Repository
{
    public interface ITrainRepository
    {
        List<Train> GetTrains(string from, string to);
     List<DropDownModel> GetCities(string search);
    List<PassengerModel> GetPassengers(int trainNumber, int bogiId);

    bool UpdatePassengerPresentStatus(PassengerModel data);

    PassengerModel ReplacePassenger(ReplacePassengerModel rModel);

  }
}

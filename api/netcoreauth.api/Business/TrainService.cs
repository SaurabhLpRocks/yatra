using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netcoreauth.api.DataStore;
using netcoreauth.api.Repository;
using netcoreauth.model;

namespace netcoreauth.api.Business
{
  public class TrainService : ITrainService
  {
    private readonly ITrainRepository _iTrainRepository;
    public TrainService(ITrainRepository iTrainRepository)
    {
      _iTrainRepository = iTrainRepository;
    }

    public List<DropDownModel> GetCities()
    {
      return _iTrainRepository.GetCities();
    }

   
    public List<Train> GetTrains(string from, string to)
    {
      return _iTrainRepository.GetTrains(from, to);
    }

    public List<PassengerModel> GetPassengers(int trainNumber, int bogiId) {
      return _iTrainRepository.GetPassengers(trainNumber, bogiId);
    }
  }
}

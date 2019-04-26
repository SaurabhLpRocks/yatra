using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public List<Train> GetTrains()
        {
            return _iTrainRepository.GetTrains();
        }
    }
}

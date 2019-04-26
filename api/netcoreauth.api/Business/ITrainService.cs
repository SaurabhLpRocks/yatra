using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netcoreauth.model;

namespace netcoreauth.api.Business
{
    public interface ITrainService
    {
        List<Train> GetTrains();
    }
}

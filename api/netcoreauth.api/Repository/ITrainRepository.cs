using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netcoreauth.model;

namespace netcoreauth.api.Repository
{
    public interface ITrainRepository
    {
        List<Train> GetTrains(string from, string to);
    }
}

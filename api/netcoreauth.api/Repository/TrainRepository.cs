using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using netcoreauth.model;
using Newtonsoft.Json;

namespace netcoreauth.api.Repository
{
    public class TrainRepository : ITrainRepository
    {
        public List<Train> TrainList = new List<Train>();        

        public List<Train> LoadJson()
        {
            using (StreamReader r = new StreamReader("~/DataStore/TrainList.json"))
            {
                string json = r.ReadToEnd();
                TrainList = JsonConvert.DeserializeObject<List<Train>>(json);
            }
            return TrainList;
        }

        public List<Train> GetTrains()
        {
            return this.LoadJson();
        }
    }
    
}

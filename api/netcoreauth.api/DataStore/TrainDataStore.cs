using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netcoreauth.model;

namespace netcoreauth.api.DataStore
{
  public static class TrainDataStore
  {
    public static List<Train> TrainList = new List<Train>()
        {
            new Train { Id = 12345, TrainName = "Gitanjali", From = "Nagpur", To= "Pune", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "ac3", Accuracy = 50 } } },
            new Train { Id = 5678, TrainName = "Sampakranti Express", From = "Nagpur", To= "Mumbai", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "ac3", Accuracy = 90 } } },
            new Train { Id = 22692, TrainName = "Bangalore Rajdhani", From = "Mumbai", To= "Bangalore", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "ac3", Accuracy = 60 } } },
            new Train { Id = 12622, TrainName = "TamilNadu Express", From = "Hyderabad", To= "Bangalore", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 24 }, new Prediction { Class = "ac3", Accuracy = 20 } } },
            new Train { Id = 12722, TrainName = "Dakshin Express", From = "Hyderabad", To= "Pune", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "ac3", Accuracy = 40 } } },
            new Train { Id = 22416, TrainName = "A P Express", From = "Pune", To= "Nagpur", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 60 }, new Prediction { Class = "ac3", Accuracy = 80 } } },
            new Train { Id = 12808, TrainName = "Samata Express", From = "Nagpur", To= "Hyderabad",  Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 30 }, new Prediction { Class = "ac3", Accuracy = 30 } } },
            new Train { Id = 12626, TrainName = "Kerala Express", From = "Nagpur", To= "Hyderabad", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 80 }, new Prediction { Class = "ac3", Accuracy = 50 } } },
            new Train { Id = 12434, TrainName = "Chennai Rajdhani", From = "Nagpur", To= "Pune", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 100 }, new Prediction { Class = "ac3", Accuracy = 10 } } },
            new Train { Id = 12406, TrainName = "Gondwana Express", From = "Hyderabad", To= "Nagpur", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 50 }, new Prediction { Class = "ac3", Accuracy = 70 } } }
        };
  }
}

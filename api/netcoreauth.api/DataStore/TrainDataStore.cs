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

            new Train { TrainNumber = 12345, Name = "Gitanjali", From = "Nagpur", To= "Pune", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "Ac3", Accuracy = 50 } } },
            new Train { TrainNumber = 5678 , Name = "Sampakranti Express", From = "Nagpur", To= "Mumbai", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "Ac3", Accuracy = 90 } } },
            new Train { TrainNumber = 22692, Name = "Bangalore Rajdhani", From = "Mumbai", To= "Bangalore", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "Ac3", Accuracy = 60 } } },
            new Train { TrainNumber = 12622, Name = "TamilNadu Express", From = "Hyderabad", To= "Bangalore", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 24 }, new Prediction { Class = "Ac3", Accuracy = 20 } } },
            new Train { TrainNumber = 12722, Name = "Dakshin Express", From = "Hyderabad", To= "Pune", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "Ac3", Accuracy = 40 } } },
            new Train { TrainNumber = 22416, Name = "A P Express", From = "Pune", To= "Nagpur", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 60 }, new Prediction { Class = "Ac3", Accuracy = 80 } } },
            new Train { TrainNumber = 12808, Name = "Samata Express", From = "Nagpur", To= "Hyderabad",  Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 30 }, new Prediction { Class = "Ac3", Accuracy = 30 } } },
            new Train { TrainNumber = 12626, Name = "Kerala Express", From = "Nagpur", To= "Hyderabad", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 80 }, new Prediction { Class = "Ac3", Accuracy = 50 } } },
            new Train { TrainNumber = 12434, Name = "Chennai Rajdhani", From = "Nagpur", To= "Pune", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 100 }, new Prediction { Class = "Ac3", Accuracy = 10 } } },
            new Train { TrainNumber = 12406, Name = "Gondwana Express", From = "Hyderabad", To= "Nagpur", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 50 }, new Prediction { Class = "Ac3", Accuracy = 70 } } }

   };
  }
}

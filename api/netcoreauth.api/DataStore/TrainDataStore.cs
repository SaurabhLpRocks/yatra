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
            new Train
            {
                      TrainNumber = 12345,
                      Name = "Gitanjali",
                      From = "Nagpur",
                      DepartHrs = 22,
                      DepartMin = 59,
                      InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Ajni", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Wardha", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Pulgaon", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Badnera", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Shegaon", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Daund", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Pune", TotalHrs = "12:00",
                    Prediction = new List<Prediction>()
                        { new Prediction { Class = "sleeper", Accuracy = 20 },
                          new Prediction { Class = "ac3", Accuracy = 50 } }
            },

            new Train { TrainNumber = 5678, Name = "Sampakranti Express", From = "Nagpur",DepartHrs = 20,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Ajni", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Sevagram", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "DhamanGaon", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Egatpuri", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Kalyan", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Dadar", DepartHrs = 15, DepartMin = 00 }
                  }, TotalHrs = "02:00", To= "Mumbai", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "ac3", Accuracy = 90 } } },

            new Train { TrainNumber = 22692, Name = "Bangalore Rajdhani", From = "Mumbai", DepartHrs = 18,
                      DepartMin = 59,  InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Pune", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "belgaum", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Davangere", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Kadur", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Kalyan", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Tumkur", DepartHrs = 15, DepartMin = 00 }
                  },
                   To= "Bangalore", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "ac3", Accuracy = 60 } } },

      new Train { TrainNumber = 12622, Name = "TamilNadu Express", From = "Hyderabad", DepartHrs = 19,
                      DepartMin = 59,  InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Secundarabad", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Lingampalli", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Raichur", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Kadur", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Hindupur", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Tumkur", DepartHrs = 15, DepartMin = 00 }
                  },
                   To= "Bangalore", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 24 }, new Prediction { Class = "ac3", Accuracy = 20 } } },

      new Train { TrainNumber = 12722, Name = "Dakshin Express", From = "Hyderabad", DepartHrs = 19,
                      DepartMin = 59,  InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Begumpeth", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Zahirabad", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Latur", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Usmanabad", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Daund", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Tumkur", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Pune", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "ac3", Accuracy = 40 } } },

      new Train { TrainNumber = 22416, Name = "A P Express", From = "Pune", DepartHrs = 21,
                      DepartMin = 59,   InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Daund", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Kopargaon", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Shegaon", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Akola", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Pulgaon", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Ajni", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Nagpur", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 60 }, new Prediction { Class = "ac3", Accuracy = 80 } } },

      new Train { TrainNumber = 12808, Name = "Samata Express", From = "Delhi", DepartHrs = 21,
                      DepartMin = 59,  InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Mathura", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Agra", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Gwalior", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Balharshah", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Secundarabad", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Hyderabad", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 30 }, new Prediction { Class = "ac3", Accuracy = 30 } } },

      new Train { TrainNumber = 12626, Name = "Kerala Express", From = "Nagpur", DepartHrs = 22,
                      DepartMin = 59,  InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Balharshah", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Warangel", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Tirupati", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Chittor", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Balharshah", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Trivandram", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Kerala", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 80 }, new Prediction { Class = "ac3", Accuracy = 50 } } },

      new Train { TrainNumber = 12434, Name = "Chennai Rajdhani", From = "Pune", DepartHrs = 23,
                      DepartMin = 00, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Gulbarga", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Yadir", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Raichur", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Chittor", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Razampetha", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Perambur", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Chennai", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 100 }, new Prediction { Class = "ac3", Accuracy = 10 } } },

      new Train { TrainNumber = 12406, Name = "Gondwana Express", From = "Nagpur", DepartHrs = 09,
                      DepartMin = 00, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Ajni", DepartHrs = 10, DepartMin = 00 },
                        new Station { Id = 2, Name = "Wardha", DepartHrs = 11, DepartMin = 00 },
                        new Station { Id = 3, Name = "Shegaon", DepartHrs = 12, DepartMin = 00 },
                        new Station { Id = 4, Name = "Bhusawal", DepartHrs = 13, DepartMin = 00 },
                        new Station { Id = 5, Name = "Kopargaon", DepartHrs = 14, DepartMin = 00 },
                        new Station { Id = 6, Name = "Daund", DepartHrs = 15, DepartMin = 00 }
                  }, To= "Pune", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 50 }, new Prediction { Class = "ac3", Accuracy = 70 } } }
        };


    public static List<BogiModel> BogiList = new List<BogiModel>() {
      new BogiModel{ Id = 1, Bogi="S3", TrainNumber = 12345},
      new BogiModel{ Id = 2, Bogi="S4", TrainNumber = 12345},
      new BogiModel{ Id = 3, Bogi="S3", TrainNumber = 5678},
      new BogiModel{ Id = 4, Bogi="S3", TrainNumber = 5678}
    };


    public static List<PassengerModel> Passengers = new List<PassengerModel>()
    {
      new PassengerModel { Id = 1, TrainNumber = 12345, Bogi="S3", BogiId = 1, Seat=1 , Name = "Sagar Charde", IsPresent=true},
      new PassengerModel { Id = 2, TrainNumber = 12345, Bogi="S3", BogiId = 1, Seat=2 , Name = "Ram Pyare", IsPresent=true},
      new PassengerModel { Id = 3, TrainNumber = 12345, Bogi="S3", BogiId = 1, Seat=3 , Name = "Rahul Warma", IsPresent=true},
      new PassengerModel { Id = 4, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=1 , Name = "Vaibhav Bharuka", IsPresent=true},
      new PassengerModel { Id = 5, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=2 , Name = "Sourabh Palatkar", IsPresent=true},
      new PassengerModel { Id = 6, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=3 , Name = "Swapnil", IsPresent=true},
      new PassengerModel { Id = 7, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=4 , Name = "Chetan", IsPresent=true},
    };
}

public class BogiModel
{
  public int Id { get; set; }
  public int TrainNumber { get; set; }
  public string Bogi { get; set; }
}

public class PassengerModel
{
  public int Id { get; set; }
  public int TrainNumber { get; set; }
  public string Bogi { get; set; }
  public int BogiId { get; set; }
  public int Seat { get; set; }
  public string Name { get; set; }
  public bool IsPresent { get; set; }
}
}

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
                      TrainNumber = 12859,
                      Name = "Gitanjali Express",
                      TrainType = 0.6,
                      From = "Mumbai",
                      DepartHrs = 22,
                      DepartMin = 59,
                      InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 10, DepartMin = 00, Accuracy = 20 },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 11, DepartMin = 00, Accuracy = 10 },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 12, DepartMin = 00, Accuracy = 20 },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 13, DepartMin = 00, Accuracy= 10 },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 14, DepartMin = 00, Accuracy =20 },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 15, DepartMin = 00, Accuracy= 25 }
                  }, To= "Kolkata", TotalHrs = "12:00",
                    Prediction = new List<Prediction>()
                        { new Prediction { Class = "Sleeper", Accuracy = 20 },
                          new Prediction { Class = "AC3", Accuracy = 50 } }
            },

            new Train { TrainNumber = 12101, Name = "Jnaneswari Delx", TrainType = 0.6, From = "Mumbai",DepartHrs = 20,
                      DepartMin = 59,  InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 02, DepartMin = 00, Accuracy = 10 },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 03, DepartMin = 00, Accuracy = 22  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 04, DepartMin = 00, Accuracy = 12  },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 06, DepartMin = 00, Accuracy = 30  },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 07, DepartMin = 00, Accuracy = 4  },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 08, DepartMin = 00, Accuracy = 5  }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 10 }, new Prediction { Class = "AC3", Accuracy = 90 } } },

            new Train { TrainNumber = 12869, Name = "Howrah Superfast", TrainType = 0.6, From = "Mumbai", DepartHrs = 18,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 20, DepartMin = 00, Accuracy = 21  },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 21, DepartMin = 00, Accuracy = 22  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 22, DepartMin = 00, Accuracy = 31  },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 23, DepartMin = 00, Accuracy = 23 },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 24, DepartMin = 00, Accuracy = 22 },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 25, DepartMin = 00, Accuracy = 33 }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 20 }, new Prediction { Class = "AC3", Accuracy = 60 } } },

      new Train { TrainNumber = 12809, Name = "Howrah Mail", TrainType = 0.6, From = "Mumbai", DepartHrs = 19,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 20, DepartMin = 00, Accuracy = 2  },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 22, DepartMin = 00, Accuracy = 6  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 23, DepartMin = 00, Accuracy = 7 },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 02, DepartMin = 00, Accuracy = 9 },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 03, DepartMin = 00, Accuracy = 14 },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 04, DepartMin = 00, Accuracy = 11 }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 24 }, new Prediction { Class = "AC3", Accuracy = 20 } } },

      new Train { TrainNumber = 15611, Name = "Karmabhoomi", TrainType = 0.6, From = "Mumbai", DepartHrs = 19,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 20, DepartMin = 00, Accuracy = 9  },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 22, DepartMin = 00, Accuracy = 10  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 23, DepartMin = 00, Accuracy = 11  },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 02, DepartMin = 00, Accuracy = 32  },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 03, DepartMin = 00, Accuracy = 45  },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 04, DepartMin = 00, Accuracy = 65  }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 10 }, new Prediction { Class = "AC3", Accuracy = 40 } } },

      new Train { TrainNumber = 05611, Name = "Lokmanyatilak Special", TrainType = 0.8, From = "Mumbai", DepartHrs = 21,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 22, DepartMin = 00, Accuracy = 12  },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 23, DepartMin = 00, Accuracy = 22  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 24, DepartMin = 00, Accuracy = 23  },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 01, DepartMin = 00, Accuracy = 21  },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 02, DepartMin = 00, Accuracy = 25  },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 04, DepartMin = 00, Accuracy = 15 }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 60 }, new Prediction { Class = "AC3", Accuracy = 80 } } },

      new Train { TrainNumber = 12151, Name = "Samarsata", TrainType = 0.4, From = "Mumbai", DepartHrs = 10,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 11, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 13, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 14, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 18, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 20, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 23, DepartMin = 00, Accuracy = 20  }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 30 }, new Prediction { Class = "AC3", Accuracy = 30 } } },

      new Train { TrainNumber = 18029, Name = "Shalimar", TrainType = 0.4, From = "Mumbai", DepartHrs = 22,
                      DepartMin = 59, InBetweenStations = new List<Station>()
                        { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 23, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 24, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 3, Name = "Akola Junction", DepartHrs = 03, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 4, Name = "Nagpur", DepartHrs = 04, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 06, DepartMin = 00, Accuracy = 20  },
                        new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 07, DepartMin = 00, Accuracy = 20  }
                  }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 80 }, new Prediction { Class = "AC3", Accuracy = 50 } } },

      //new Train { TrainNumber = 12434, Name = "Chennai Rajdhani", From = "Mumbai", DepartHrs = 23,
      //                DepartMin = 00,InBetweenStations = new List<Station>()
      //                  { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 01, DepartMin = 00 },
      //                  new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 02, DepartMin = 00 },
      //                  new Station { Id = 3, Name = "Akola Junction", DepartHrs = 04, DepartMin = 00 },
      //                  new Station { Id = 4, Name = "Nagpur", DepartHrs = 05, DepartMin = 00 },
      //                  new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 06, DepartMin = 00 },
      //                  new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 07, DepartMin = 00 }
      //            }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 100 }, new Prediction { Class = "AC3", Accuracy = 10 } } },

      //new Train { TrainNumber = 12406, Name = "Gondwana Express", From = "Mumbai", DepartHrs = 09,
      //                DepartMin = 00, InBetweenStations = new List<Station>()
      //                  { new Station { Id = 1, Name = "Nasik Road", DepartHrs = 10, DepartMin = 00 },
      //                  new Station { Id = 2, Name = "Bhusaval Junction", DepartHrs = 13, DepartMin = 00 },
      //                  new Station { Id = 3, Name = "Akola Junction", DepartHrs = 14, DepartMin = 00 },
      //                  new Station { Id = 4, Name = "Nagpur", DepartHrs = 17, DepartMin = 00 },
      //                  new Station { Id = 5, Name = "Bilaspur Junction", DepartHrs = 18, DepartMin = 00 },
      //                  new Station { Id = 6, Name = "Kharagpur Junction", DepartHrs = 21, DepartMin = 00 }
      //            }, To= "Kolkata", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "Sleeper", Accuracy = 50 }, new Prediction { Class = "AC3", Accuracy = 70 } } }
        };

    public static List<BogiModel> BogiList = new List<BogiModel>() {
      new BogiModel{ Id = 1, Bogi="S3", TrainNumber = 12345},
      new BogiModel{ Id = 2, Bogi="S4", TrainNumber = 12345},
      new BogiModel{ Id = 3, Bogi="S3", TrainNumber = 5678},
      new BogiModel{ Id = 4, Bogi="S3", TrainNumber = 5678}
    };


    public static List<PassengerModel> Passengers = new List<PassengerModel>()
    {
      new PassengerModel { Id = 1, TrainNumber = 12345, Bogi="S3", BogiId = 1, Seat=1 , Name = "Hemendra Prasad ", IsPresent=true},
      new PassengerModel { Id = 2, TrainNumber = 12345, Bogi="S3", BogiId = 1, Seat=2 , Name = "Urmila Keer ", IsPresent=true},
      new PassengerModel { Id = 3, TrainNumber = 12345, Bogi="S3", BogiId = 1, Seat=3 , Name = "Rahul Warma", IsPresent=true},
      new PassengerModel { Id = 4, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=1 , Name = "Nidhi Gala", IsPresent=true},
      new PassengerModel { Id = 5, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=2 , Name = "Sourabh Palatkar", IsPresent=true},
      new PassengerModel { Id = 6, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=3 , Name = "Omar Deshpande ", IsPresent=true},
      new PassengerModel { Id = 7, TrainNumber = 12345, Bogi="S4", BogiId = 2, Seat=4 , Name = "Chetan Sharma", IsPresent=true},
      new PassengerModel { Id = 8, TrainNumber = 12345, Bogi="S5", BogiId = 3, Seat=10 , Name = "Destin Kuhic", IsPresent=true},
      new PassengerModel { Id = 9, TrainNumber = 12345, Bogi="S5", BogiId = 3, Seat=11 , Name = "Cierra Crist", IsPresent=true},
      new PassengerModel { Id = 10, TrainNumber = 12345, Bogi="S5", BogiId = 3, Seat=12 , Name = "Dallas Rogahn", IsPresent=true},
      new PassengerModel { Id = 11, TrainNumber = 12345, Bogi="S5", BogiId = 3, Seat=12 , Name = "Karen Wilderman", IsPresent=true},
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
    public bool? IsReplaced { get; set; }
  }

  public class ReplacePassengerModel
  {
    public PassengerModel PassengerModel { get; set; }
    public string NewPassengerName { get; set; }

  }
}

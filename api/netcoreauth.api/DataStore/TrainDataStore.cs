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
            new Train { TrainNumber = 12345, Name = "Gitanjali", From = "Nagpur", Depart = "10:00", InBetweenStations = new List<string>{ "Ajni", "Wardha", "Pulgaon", "Badnera", "Shegaon", "Daund" }, InBetweenStationsTime = new List<string>{ "10:05", "11.09", "11.30", "12:40", "22:12", "22:58" }, To= "Pune", TotalHrs = "12:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "ac3", Accuracy = 50 } } },
            new Train { TrainNumber = 5678, Name = "Sampakranti Express", From = "Nagpur", Depart = "12:00", InBetweenStations = new List<string>{ "Ajni", "Sevagram", "DhamanGaon", "Egatpuri", "Kalyan", "Dadar" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15", "13:30", "13:45" }, TotalHrs = "02:00", To= "Mumbai", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "ac3", Accuracy = 90 } } },
            new Train { TrainNumber = 22692, Name = "Bangalore Rajdhani", From = "Mumbai", Depart = "12:00", InBetweenStations = new List<string>{ "Pune Junction", "belgaum", "Davangere", "Kadur", "Tumkur" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15", "13:30" }, To= "Bangalore", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 20 }, new Prediction { Class = "ac3", Accuracy = 60 } } },
            new Train { TrainNumber = 12622, Name = "TamilNadu Express", From = "Hyderabad", Depart = "12:00", InBetweenStations = new List<string>{ "Secundarabad", "Lingampalli", "Raichur", "Hindupur" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15" }, To= "Bangalore", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 24 }, new Prediction { Class = "ac3", Accuracy = 20 } } },
            new Train { TrainNumber = 12722, Name = "Dakshin Express", From = "Hyderabad", Depart = "12:00", InBetweenStations = new List<string>{ "Begumpeth", "Zahirabad", "Latur", "Usmanabad", "Daund" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15",  "13:30" },  To= "Pune", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 10 }, new Prediction { Class = "ac3", Accuracy = 40 } } },
            new Train { TrainNumber = 22416, Name = "A P Express", From = "Pune", Depart = "12:00",  InBetweenStations = new List<string>{ "Daund", "Kopargaon", "Shegaon", "Akola", "Pulgaon", "Ajni" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15",  "13:30", "13:45" }, To= "Nagpur", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 60 }, new Prediction { Class = "ac3", Accuracy = 80 } } },
            new Train { TrainNumber = 12808, Name = "Samata Express", From = "Delhi", Depart = "12:00", InBetweenStations = new List<string>{ "Mathura", "Agra", "Gwalior", "Nagpur", "Balharshah", "Secundarabad" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15",  "13:30", "13:45" }, To= "Hyderabad", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 30 }, new Prediction { Class = "ac3", Accuracy = 30 } } },
            new Train { TrainNumber = 12626, Name = "Kerala Express", From = "Nagpur", Depart = "12:00", InBetweenStations = new List<string>{ "Balharshah", "Warangel", "Tirupati", "Chittor", "Trivandram" }, InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15",  "13:30" }, To= "Kerala", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 80 }, new Prediction { Class = "ac3", Accuracy = 50 } } },
            new Train { TrainNumber = 12434, Name = "Chennai Rajdhani", From = "Pune", Depart = "12:00", InBetweenStations = new List<string>{ "Gulbarga", "Yadir", "Raichur", "Razampetha", "Perambur" },  InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15",  "13:30" },  To= "Chennai", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 100 }, new Prediction { Class = "ac3", Accuracy = 10 } } },
            new Train { TrainNumber = 12406, Name = "Gondwana Express", From = "Nagpur", Depart = "12:00", InBetweenStations = new List<string>{ "Ajni", "Wardha", "Shegaon", "Bhusawal", "Kopargaon", "Daund" },  InBetweenStationsTime = new List<string>{ "12:30", "12:45", "13:00", "13:15",  "13:30", "13:45" }, To= "Pune", TotalHrs = "02:00", Prediction = new List<Prediction>(){ new Prediction { Class = "sleeper", Accuracy = 50 }, new Prediction { Class = "ac3", Accuracy = 70 } } }
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

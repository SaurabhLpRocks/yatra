using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace netcoreauth.model
{
  public class Train
  {
    [Key]
    public int TrainNumber { get; set; }
    public string Name { get; set; }
    public string From { get; set; }
    public string Depart { get; set; }
    public string To { get; set; }
    public string TotalHrs { get; set; }
    public List<string> InBetweenStations { get; set; }
    public List<string> InBetweenStationsTime { get; set; }
    public List<Prediction> Prediction { get; set; }
  }
}

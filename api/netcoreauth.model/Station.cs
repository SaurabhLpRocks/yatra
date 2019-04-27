using System;
using System.Collections.Generic;
using System.Text;

namespace netcoreauth.model
{
  public class Station
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartHrs { get; set; }
    public int DepartMin { get; set; }
  }
}

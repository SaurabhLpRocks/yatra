using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using netcoreauth.api.Business;
using netcoreauth.api.DataStore;
using netcoreauth.model;

namespace netcoreauth.api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TrainController : ControllerBase
  {
    private readonly ITrainService _iTrainService;
    public TrainController(ITrainService iTrainService)
    {
      _iTrainService = iTrainService;
    }

    [HttpGet]
    public IActionResult Get(string from, string to)
    {
      var data = _iTrainService.GetTrains(from, to);
      return Ok(data);
    }

    [HttpGet("GetCities")]
    public IActionResult GetCities()
    {
      var data = _iTrainService.GetCities();
      return Ok(data);
    }


    [HttpGet("GetPassengers")]
    public IActionResult GetPassengers(int trainNumber, int bogiId)
    {
      var data = _iTrainService.GetPassengers(trainNumber, bogiId);
      return Ok(data);
    }

    [HttpPost("PostPassenger")]
    public IActionResult PostPassenger([FromBody]PassengerModel data)
    {
      _iTrainService.UpdatePassengerPresentStatus(data);
      return Ok(data);
    }


    [HttpPost("ReplacePassenger")]
    public IActionResult ReplacePassenger([FromBody]ReplacePassengerModel data)
    {
      PassengerModel newData = _iTrainService.ReplacePassenger(data);
      return Ok(newData);
    }

    [HttpPost("SendUserTrainSelectedTrack")]
    public IActionResult SendUserTrainSelectedTrack([FromBody]USerTrainTrack data)
    {
      return Ok(data);
    }
  }


  public class USerTrainTrack
  {
    public int Train { get; set; }
    public string UserName { get; set; }
  }

}

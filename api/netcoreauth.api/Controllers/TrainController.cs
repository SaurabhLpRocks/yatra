using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using netcoreauth.api.Business;
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
    }
}

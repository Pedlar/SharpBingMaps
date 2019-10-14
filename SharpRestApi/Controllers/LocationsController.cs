using Microsoft.AspNetCore.Mvc;
using SharpShared.Models;
using System.Collections.Generic;

namespace SharpRestApi.Controllers {
    [Route("api/[controller]")]
    public class LocationsController : Controller {

        [HttpGet]
        public IEnumerable<Location> Get() {
            List<Location> baseLocationList = new List<Location>();
            baseLocationList.Add(new Location("Austin", 30.2642, -97.7476));
            baseLocationList.Add(new Location("Eugene", 44.033, -123.111));
            return baseLocationList;
        }
    }
}

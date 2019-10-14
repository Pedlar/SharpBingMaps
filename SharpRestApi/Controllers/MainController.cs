using Microsoft.AspNetCore.Mvc;

namespace SharpRestApi.Controllers {

    [Route("api/")]
    public class MainController : Controller {

        [HttpGet]
        public string GetIndex() {
            return "Index";
        }
    }
}

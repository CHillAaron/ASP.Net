using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}
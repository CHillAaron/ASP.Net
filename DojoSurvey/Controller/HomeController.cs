using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
         public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Method(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View();
        }
    }
}
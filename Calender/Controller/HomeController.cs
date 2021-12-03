using Microsoft.AspNetCore.Mvc;
using System;
namespace Calender.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;
            return View();
        }
    }
}
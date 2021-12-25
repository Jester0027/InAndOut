using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    [Route("/appointments")]
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

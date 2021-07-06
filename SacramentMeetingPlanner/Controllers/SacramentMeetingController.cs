using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Controllers
{
    public class SacramentMeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

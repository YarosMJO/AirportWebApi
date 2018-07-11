using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebApi.Controllers
{
    public class CrewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
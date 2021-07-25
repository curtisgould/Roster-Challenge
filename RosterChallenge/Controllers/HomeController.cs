using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RosterChallenge.ContextClasses;
using RosterChallenge.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RosterChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RosterContext _rosterContext;

        public HomeController(ILogger<HomeController> logger, RosterContext rc)
        {
            _logger = logger;
            _rosterContext = rc;
        }

        public IActionResult Index()
        {
            RosterModel roster = new RosterModel(_rosterContext);

            return View(roster);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

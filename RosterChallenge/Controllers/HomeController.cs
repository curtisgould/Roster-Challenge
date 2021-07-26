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

        [HttpPost]
        public JsonResult AddArtist(string artist, double rate, int streams, bool paid)
        {
            try
            {
                Artist _artist = new Artist
                {
                    artist = artist,
                    streams = streams,
                    rate = rate,
                    paid = paid
                };

                _rosterContext.Add(_artist);
                _rosterContext.SaveChanges();

                return Json(new { success = true, ID = _artist.ID });
            }
            catch (Exception e)
            {
                _logger.LogTrace(e.StackTrace);
                return Json(new { success = false, error = e.InnerException.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateArtist(int ID, string artist, double rate, int streams, bool paid)
        {
            try
            {
                Artist _artist = new Artist
                {
                    ID = ID,
                    artist = artist,
                    streams = streams,
                    rate = rate,
                    paid = paid
                };

                _rosterContext.Update(_artist);
                _rosterContext.SaveChanges();

                return Json(new { success = true, ID = _artist.ID });
            }
            catch (Exception e)
            {
                _logger.LogTrace(e.StackTrace);
                return Json(new { success = false, error = e.InnerException.Message });
            }
        }

        [HttpPost]
        public JsonResult getArtistByID(int ID)
        {
            try
            {
                Artist artist = _rosterContext.Artists.Where(m => m.ID == ID).FirstOrDefault();
                return Json(new { success = true, artist = artist });
            }
            catch (Exception e)
            {
                _logger.LogTrace(e.StackTrace);
                return Json(new { success = false, error = e.InnerException.Message });
            }
        }

        [HttpPost]
        public JsonResult updatePaidArtistByID(int ID, bool paid)
        {
            try
            {
                Artist artist = _rosterContext.Artists.Where(m => m.ID == ID).FirstOrDefault();
                artist.paid = paid;
                _rosterContext.Update(artist);
                _rosterContext.SaveChanges();
                return Json(new { success = true });
            }
            catch (Exception e)
            {
                _logger.LogTrace(e.StackTrace);
                return Json(new { success = false, error = e.InnerException.Message });
            }
        }

        [HttpPost]
        public JsonResult deleteArtistByID(int ID)
        {
            try
            {
                Artist artist = _rosterContext.Artists.Where(m => m.ID == ID).FirstOrDefault();
                _rosterContext.Remove(artist);
                _rosterContext.SaveChanges();
                return Json(new { success = true });
            }
            catch (Exception e)
            {
                _logger.LogTrace(e.StackTrace);
                return Json(new { success = false, error = e.Message });
            }
        }

        [HttpPost]
        public PartialViewResult getArtistRow(int ID)
        {
            Artist artist = _rosterContext.Artists.Where(m => m.ID == ID).FirstOrDefault();
            return PartialView("~/Views/Home/Partials/_rosterRow.cshtml", artist);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

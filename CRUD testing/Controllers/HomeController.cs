using CRUD_testing.Data;
using CRUD_testing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CRUD_testing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        const string SessionCart = "_Cart";

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            List<Songs> model = _context.Songs.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Songs()
        {
            List<Songs> model = _context.Songs.ToList();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search(String SearchString)

        {

            if (!string.IsNullOrEmpty(SearchString))

            {


                var songs = from m in _context.Songs

                            where m.songName.Contains(SearchString)

                            select m;

                List<Songs> model = songs.ToList();

                ViewData["SearchString"] = SearchString;

                return View(model);

            }
            else
            {
                return View();
            }



        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songs = await _context.Songs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (songs == null)
            {
                return NotFound();
            }

            return View(songs);
        }


        public IActionResult SessionDemo()
        {
            if (HttpContext.Session.GetString("Name") == null)
            {
                ViewData["myName"] = "Not Set";
            }
            else
            {
                ViewData["myName"] = HttpContext.Session.GetString("Name"); ;

            }
            return View();
        }

        [HttpPost]
        public IActionResult SessionDemo(IFormCollection form)
        {
            string newName = form["myName"].ToString();
            HttpContext.Session.SetString("Name", newName);
            ViewData["myName"] = newName;
            return View();
        }

        public IActionResult TestSession()
        {
            if (HttpContext.Session.GetString("Name") == null)
            {
                ViewData["myName"] = "Not Set";
            }
            else
            {
                ViewData["myName"] = HttpContext.Session.GetString("Name");
                HttpContext.Session.GetString(SessionCart); 
            }
            return View();
        }

        public IActionResult DeleteSession()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/SessionDemo");
        }

    }
}

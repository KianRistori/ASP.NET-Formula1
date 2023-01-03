using ASP.NET_Formula1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Formula1.Controllers
{
    public class HomeController : Controller
    {
        public Formula1Store db = new Formula1Store();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Motori()
        {
            IEnumerable<Engine> engines = db.Engines;
            return View(engines);
        }

        public IActionResult NuovoMotore()
        {
            return View();
        }

        public IActionResult NuovaScuderia()
        { 
            return View(new ScuderiaViewModel { engines=db.Engines});
        }

        [HttpPost]
        public IActionResult NuovoMotore(Engine motore)
        {
            db.Engines.Add(motore);
            db.SaveChanges();
            return RedirectToAction("motori");
        }

        [HttpPost]
        public IActionResult NuovaScuderia(ScuderiaViewModel scuderia)
        {
            Team team = new Team { Name = scuderia.TeamName, EngineId = scuderia.EngineId };
            db.Teams.Add(team);
            db.SaveChanges();
            return RedirectToAction("scuderie");
        }

        public IActionResult NuovoPilota()
        {
            return View(new PilotaViewModel { Teams = db.Teams });
        }

        [HttpPost]
        public IActionResult NuovoPilota(PilotaViewModel pilota)
        {
            if (!ModelState.IsValid)
            {
                return View(pilota);
            }
            Driver driver = new Driver {};
            db.Drivers.Add(driver);
            db.SaveChanges();
            //da ridare come parametro i team se non funziona
            return View(pilota);
            return RedirectToAction("piloti");
        }

        public IActionResult Piloti()
        {
            IEnumerable<Driver> drivers = db.Drivers;
            ScuderiaPiloti scuderiaPiloti = new ScuderiaPiloti { Drivers = drivers, NomeTeam = "Tutti i piloti"};
            return View(scuderiaPiloti);
        }

        public IActionResult Scuderie()
        {
            IEnumerable<Team> teams = db.Teams;
            return View(teams);
        }

        public IActionResult ScuderiePerMotore(int id)
        {
            IEnumerable<Team> teams = db.Teams.Where(e=>e.TeamId == id);
            return View("Scuderie" , teams);
        }

        public IActionResult PilotiPerScuderia(int id)
        {
            IEnumerable<Driver> drivers = db.Drivers.Where(d => d.TeamId == id);
            ScuderiaPiloti scuderiaPiloti = new ScuderiaPiloti { Drivers = drivers, NomeTeam = db.Teams.Where(t => t.TeamId == id).Single().Name };
            return View("Piloti", scuderiaPiloti);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

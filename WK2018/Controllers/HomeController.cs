using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WK2018.Models;

namespace WK2018.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Poules()
        {
            List<Team> teams = new List<Team>()
            {
                new Team
                {
                    Naam = "België",
                    Poule_ID = 1,
                }
                ,
                new Team
                {
                    Naam = "Frankrijk",
                    Poule_ID = 1,
                },
                 new Team
                {
                    Naam = "Ierland",
                    Poule_ID = 1,
                },
                  new Team
                {
                    Naam = "Spanje",
                    Poule_ID = 1,
                }
            };

            List<Poule> poules = new List<Poule>()
            {
                new Poule
                {
                    ID= 1,
                    Naam= 'A',
                    Teams = teams
                }
            };

            return View(poules);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

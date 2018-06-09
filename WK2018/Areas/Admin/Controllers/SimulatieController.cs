using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WK2018.Areas.Admin.Utils;
using WK2018.Data;
using WK2018.Models;

namespace WK2018.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class SimulatieController : Controller
    {
        private readonly WKContext _context;
        private ToernooiSimulator _simulator;

        public SimulatieController(WKContext context)
        {
            _context = context;
            _simulator = new ToernooiSimulator(_context);
        }

        public IActionResult Index()
        {
            _simulator.SimuleerToernooi();

            Team winnaar = _context.Wedstrijden.Where(w => w.KnockoutID == 5).SingleOrDefault().Winnaar;

            return View(winnaar);
        }

        public IActionResult Reset()
        {
            _simulator.ResetToernooi();

            return View();
        }
    }
}
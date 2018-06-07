using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WK2018.Data;
using WK2018.Models;

namespace WK2018.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class WedstrijdController : Controller
    {
        private readonly WKContext _context;

        public WedstrijdController(WKContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Wedstrijd> wedstrijden = _context.Wedstrijden.Include(x => x.TeamThuis).Include(x => x.TeamUit).OrderBy(x => x.Datum).ToList();
            return View(wedstrijden);

        }

        public IActionResult WijzigWedstrijd(int id)
        {
            Wedstrijd wedstrijd = _context.Wedstrijden.Include(x => x.TeamThuis).Include(x => x.TeamUit).Where(x => x.ID == id).SingleOrDefault();
            return View(wedstrijd);
        }


        [HttpPost]
        public IActionResult WijzigWedstrijd(Wedstrijd wedstrijd)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wedstrijd);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(wedstrijd);
        }

        public IActionResult VoegWedstrijdToe()
        {
            ViewData["LijstTeamThuis"] = new SelectList(_context.Teams.OrderBy(x => x.Naam), "ID", "Naam");
            ViewData["LijstTeamUit"] = new SelectList(_context.Teams.OrderBy(x => x.Naam), "ID", "Naam");
            return View();
        }

        [HttpPost]
        public IActionResult VoegWedstrijdToe(Wedstrijd wedstrijd)
        {
            int i = 1;
            for (int j = 0; j < _context.Wedstrijden.Count(); j++)
            {
                List<Wedstrijd> lijst = _context.Wedstrijden.ToList(); 
                if (i == lijst[j].ID)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    wedstrijd.ID = i;
                    _context.Add(wedstrijd);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(wedstrijd);
        }
    }
}
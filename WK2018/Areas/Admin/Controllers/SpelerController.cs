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
    public class SpelerController : Controller
    {
        private readonly WKContext _context;

        public SpelerController(WKContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.ToList(); 
            return View(teams);
        }

        public IActionResult ListSpelers(int id)
        {
            List<Speler> spelers = _context.Spelers.Where(x => x.TeamID == id).ToList();
            return View(spelers);
        }

        public IActionResult WijzigSpeler(int id)
        {
            Speler speler = _context.Spelers.Where(s => s.ID == id).SingleOrDefault();
            return View(speler);
        }

        [HttpPost]
        public IActionResult WijzigSpeler(Speler speler)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speler);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("ListSpelers", new { id = speler.TeamID});
            }
            return View(speler);
        }

        public IActionResult VoegSpelerToe(int id)
        {
            Speler speler = new Speler();
            speler.TeamID = id;
            speler.Team = _context.Teams.Where(t => t.ID == id).SingleOrDefault();
            return View(speler);
        }

        [HttpPost]
        public IActionResult VoegSpelerToe(Speler speler)
        {
            int i = 1;
            for (int j = 0; j < _context.Spelers.Count(); j++)
            {
                List<Speler> lijst = _context.Spelers.ToList();
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
                    speler.ID = i;
                    _context.Add(speler);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("ListSpelers", new { id = speler.TeamID });
            }
            return View(speler);
        }

        public IActionResult VerwijderSpeler(int id)
        {
            Speler speler = _context.Spelers.Where(s => s.ID == id).SingleOrDefault();
            _context.Remove(speler);
            _context.SaveChanges();
            return RedirectToAction("ListSpelers", new { id = speler.TeamID});
        }
    }
}
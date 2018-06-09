using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WK2018.Data;
using WK2018.Models;
using Microsoft.EntityFrameworkCore;
using WK2018.Models.KnockoutViewModels;

namespace WK2018.Controllers
{
    public class KnockoutController : Controller
    {
        WKContext _context;

        public KnockoutController(WKContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Knockout> knocouts = _context.KnockoutStages.Include(k => k.Wedstrijden).ToList();

            //THE MAGIC OF ENTITY FRAMEWORK HAPPENS HERE
            foreach (var knockout in knocouts)
            {
               List<Wedstrijd> wedstrijden = _context.Wedstrijden
                    .Include(w => w.TeamUit)
                    .Include(w => w.TeamThuis)
                    .Where(w => w.KnockoutID == knockout.ID)
                    .ToList();
            }

            return View(knocouts);
        }
    }
}
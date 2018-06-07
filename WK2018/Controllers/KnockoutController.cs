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
            List<Knockout> knockoutsStages = _context.KnockoutStages.Include(k => k.Teams).ToList();

            Dictionary<String, List<Wedstrijd>> wedstrijdenPerKnockout = new Dictionary<string, List<Wedstrijd>>();

            knockoutsStages.ForEach(stage =>
            {
                List<Wedstrijd> wedstrijden = _context.Wedstrijden
                .Include(w=> w.TeamThuis)
                .Include(w=> w.TeamUit)
                .Where(w => w.TeamThuis.KnockoutID == stage.ID)
                .ToList();

                wedstrijdenPerKnockout.Add(stage.Type, wedstrijden);
            });

            IndexKnockoutViewModel vm = new IndexKnockoutViewModel() {
                KnockoutStages = knockoutsStages,
                KnockoutWedstrijden = wedstrijdenPerKnockout
            };

            return View(vm);
        }
    }
}
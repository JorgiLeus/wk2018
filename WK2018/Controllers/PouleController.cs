using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WK2018.Models;
using WK2018.Models.PouleViewModels;
using WK2018.Data;
using Microsoft.EntityFrameworkCore;

namespace WK2018.Controllers
{
    public class PouleController : Controller
    {
        private readonly WKContext _context;

        public PouleController(WKContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Poule> poules = _context.Poules.Include(p => p.Teams).OrderBy(p => p.Naam).ToList();

            return View(poules);
        }

        public IActionResult Detail(int id)
        {
            Poule poule = _context.Poules.Include(p => p.Teams).Where(p => p.ID == id).SingleOrDefault();

            DetailViewModel vm = new DetailViewModel();

            vm.Poule = poule;

            return View(vm);
        }
    }
}
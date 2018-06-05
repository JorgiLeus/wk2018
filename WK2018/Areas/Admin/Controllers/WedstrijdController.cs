using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            List<Wedstrijd> wedstrijden = _context.Wedstrijden.ToList();
            return View(wedstrijden);
        }
    }
}
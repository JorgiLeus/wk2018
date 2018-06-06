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
    public class TeamController : Controller
    {
        private readonly WKContext _context;

        public TeamController(WKContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.ToList(); 
            return View(teams);
        }

        public IActionResult WijzigTeam(int id)
        {
            Team team = _context.Teams.Where(x => x.ID == id).SingleOrDefault();
            return View(team);
        }
    }
}
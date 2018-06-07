using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Data;
using WK2018.Models;

namespace WK2018.Areas.Admin.Simulator
{
    public class ToernooiSimulator
    {
        public WKContext _context;
        private Random _random;

        public ToernooiSimulator(WKContext context)
        {
            _context = context;
            _random = new Random();
        }

        public void SimuleerGroepsfase()
        {
            List<Wedstrijd> wedstrijden = _context.Wedstrijden
                .Include(t => t.TeamThuis)
                .Include(t => t.TeamUit)
                .Where(w => w.KnockoutID == null)
                .ToList();

            foreach (var wedstrijd in wedstrijden)
            {
                Wedstrijd gesimuleerdeWedstrijd = SimuleerWedstrijd(wedstrijd);
                _context.Update(gesimuleerdeWedstrijd);
            }

            _context.SaveChanges();
        }

        public void VulInAchtsteFinale()
        {
            List<Team> eerstePlaatsen = new List<Team>();
            List<Team> tweedePlaatsen = new List<Team>();

            var query = _context.Teams
                    .Include(t => t.ThuisWedstrijden)
                    .Include(t => t.UitWedstrijden)
                    .OrderBy(t => t.Doelsaldo)
                    .OrderBy(t => t.Punten)
                    .Reverse();

            foreach (var poule in _context.Poules)
            {
                List<Team> teams = query.Where(t => t.PouleID == poule.ID).ToList();
                eerstePlaatsen.AddRange(teams.GetRange(0, 1));
                tweedePlaatsen.AddRange(teams.GetRange(1, 1));
            }

            List<Wedstrijd> achtsteWedstrijden = _context.Wedstrijden.Where(w => w.KnockoutID == 1).ToList();

            //TODO Vul wedstrijden in 
        }

        private Wedstrijd SimuleerWedstrijd(Wedstrijd wedstrijd)
        {
            wedstrijd.ScoreThuis = GetRandomScore();
            wedstrijd.ScoreUit = GetRandomScore();

            return wedstrijd;
        }

        private int GetRandomScore()
        {
            return _random.Next(0, 5);
        }
    }
}

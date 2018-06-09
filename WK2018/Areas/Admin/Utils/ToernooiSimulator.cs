using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Data;
using WK2018.Models;

namespace WK2018.Areas.Admin.Utils
{
    public class ToernooiSimulator
    {
        private readonly WKContext _context;
        private Random _random;
        private ToernooiOpvuller _opvuller;

        public ToernooiSimulator(WKContext context)
        {
            _context = context;
            _random = new Random();
            _opvuller = new ToernooiOpvuller(_context);
        }

        public void SimuleerGroepsfase()
        {
            //null is groepsfase
            List<Wedstrijd> wedstrijden = GetWedstrijdenForKnockoutID(null);

            SimuleerWedstrijden(wedstrijden);

            _opvuller.VulInAchtsteFinale();
        }

        internal void SimuleerToernooi()
        {
            SimuleerGroepsfase();
            SimuleerAchtsteFinale();
            SimuleerKwartFinale();
            SimuleerHalveFinale();
            SimuleerTroostFinale();
            SimuleerFinale();
        }

        public void SimuleerAchtsteFinale()
        {
            List<Wedstrijd> wedstrijden = GetWedstrijdenForKnockoutID(1);

            SimuleerWedstrijden(wedstrijden);

            _opvuller.VulInKwartFinale();
        }

        public void SimuleerKwartFinale()
        {
            List<Wedstrijd> wedstrijden = GetWedstrijdenForKnockoutID(2);

            SimuleerWedstrijden(wedstrijden);

            _opvuller.VulInHalveFinale();
        }

        public void SimuleerHalveFinale()
        {
            List<Wedstrijd> wedstrijden = GetWedstrijdenForKnockoutID(3);

            SimuleerWedstrijden(wedstrijden);

            _opvuller.VulInFinales();
        }

        public void SimuleerTroostFinale()
        {
            List<Wedstrijd> wedstrijden = GetWedstrijdenForKnockoutID(4);

            SimuleerWedstrijden(wedstrijden);
        }

        public void SimuleerFinale()
        {
            List<Wedstrijd> wedstrijden = GetWedstrijdenForKnockoutID(5);

            SimuleerWedstrijden(wedstrijden);
        }

        #region Helper Functions
        private void SimuleerWedstrijden(List<Wedstrijd> wedstrijden)
        {
            foreach (var wedstrijd in wedstrijden)
            {
                Wedstrijd gesimuleerdeWedstrijd = SimuleerWedstrijd(wedstrijd);
                _context.Update(gesimuleerdeWedstrijd);
            }

            _context.SaveChanges();
        }

        private List<Wedstrijd> GetWedstrijdenForKnockoutID(int? id)
        {
            return _context.Wedstrijden
                .Include(t => t.TeamThuis)
                .Include(t => t.TeamUit)
                .Where(w => w.KnockoutID == id)
                .ToList();
        }

        private Wedstrijd SimuleerWedstrijd(Wedstrijd wedstrijd)
        {
            wedstrijd.ScoreThuis = GetRandomScore(5);
            wedstrijd.ScoreUit = GetRandomScore(5);

            //Knockout Fases
            if (wedstrijd.KnockoutID != null)
            {
                //Verleningen
                if (wedstrijd.IsGelijkSpel)
                {
                    wedstrijd.ScoreThuis += GetRandomScore(2);
                    wedstrijd.ScoreUit += GetRandomScore(2);
                }

                //Penalties
                if (wedstrijd.IsGelijkSpel)
                {
                    wedstrijd.ScoreThuis += GetRandomScore(5);
                    wedstrijd.ScoreUit += GetRandomScore(5);
                }

                while (wedstrijd.IsGelijkSpel)
                {
                    wedstrijd.ScoreThuis += GetRandomScore(1);
                    wedstrijd.ScoreUit += GetRandomScore(1);
                }
            }
            
            return wedstrijd;
        }

        private int GetRandomScore(int max)
        {
            return _random.Next(0, max);
        }
        #endregion
    }
}

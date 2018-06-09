using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Data;
using WK2018.Models;

namespace WK2018.Areas.Admin.Utils
{
    public class ToernooiOpvuller
    {
        private readonly WKContext _context;

        public ToernooiOpvuller(WKContext context)
        {
            _context = context;
        }

        internal void VulInAchtsteFinale()
        {
            List<Team> eerstePlaatsen = GetAchtsteFinalisten().eerstePlaatsen;
            List<Team> tweedePlaatsen = GetAchtsteFinalisten().tweedePlaatsen;

            List<Wedstrijd> achtsteWedstrijden = GetWedstrijdForKnockoutId(1);

            achtsteWedstrijden[0].TeamThuisID = eerstePlaatsen[2].ID;
            achtsteWedstrijden[0].TeamUitID = tweedePlaatsen[3].ID;

            achtsteWedstrijden[1].TeamThuisID = eerstePlaatsen[0].ID;
            achtsteWedstrijden[1].TeamUitID = tweedePlaatsen[1].ID;

            achtsteWedstrijden[2].TeamThuisID = eerstePlaatsen[1].ID;
            achtsteWedstrijden[2].TeamUitID = tweedePlaatsen[0].ID;

            achtsteWedstrijden[3].TeamThuisID = eerstePlaatsen[3].ID;
            achtsteWedstrijden[3].TeamUitID = tweedePlaatsen[2].ID;

            achtsteWedstrijden[4].TeamThuisID = eerstePlaatsen[4].ID;
            achtsteWedstrijden[4].TeamUitID = tweedePlaatsen[5].ID;

            achtsteWedstrijden[5].TeamThuisID = eerstePlaatsen[6].ID;
            achtsteWedstrijden[5].TeamUitID = tweedePlaatsen[7].ID;

            achtsteWedstrijden[6].TeamThuisID = eerstePlaatsen[5].ID;
            achtsteWedstrijden[6].TeamUitID = tweedePlaatsen[4].ID;

            achtsteWedstrijden[7].TeamThuisID = eerstePlaatsen[7].ID;
            achtsteWedstrijden[7].TeamUitID = tweedePlaatsen[6].ID;

            UpdateWedstrijden(achtsteWedstrijden);
        }

        internal void VulInKwartFinale()
        {
            List<Wedstrijd> kwartFinales = GetWedstrijdForKnockoutId(2);
            List<Wedstrijd> achtsteWedstrijden = GetWedstrijdForKnockoutId(1);

            kwartFinales[0].TeamThuis = achtsteWedstrijden[0].Winnaar;
            kwartFinales[0].TeamUit = achtsteWedstrijden[1].Winnaar;

            kwartFinales[1].TeamThuis = achtsteWedstrijden[4].Winnaar;
            kwartFinales[1].TeamUit = achtsteWedstrijden[5].Winnaar;

            kwartFinales[2].TeamThuis = achtsteWedstrijden[6].Winnaar;
            kwartFinales[2].TeamUit = achtsteWedstrijden[7].Winnaar;

            kwartFinales[3].TeamThuis = achtsteWedstrijden[2].Winnaar;
            kwartFinales[3].TeamUit = achtsteWedstrijden[3].Winnaar;

            UpdateWedstrijden(kwartFinales);
        }

        internal void VulInHalveFinale()
        {
            List<Wedstrijd> kwartFinales = GetWedstrijdForKnockoutId(2);
            List<Wedstrijd> halveFinales = GetWedstrijdForKnockoutId(3);

            halveFinales[0].TeamThuis = kwartFinales[0].Winnaar;
            halveFinales[0].TeamUit = kwartFinales[1].Winnaar;

            halveFinales[1].TeamThuis = kwartFinales[2].Winnaar;
            halveFinales[1].TeamUit = kwartFinales[3].Winnaar;

            UpdateWedstrijden(halveFinales);
        }

        internal void VulInFinales()
        {
            Wedstrijd troostFinale = GetWedstrijdForKnockoutId(4).SingleOrDefault();
            Wedstrijd finale = GetWedstrijdForKnockoutId(5).SingleOrDefault();
            List<Wedstrijd> halveFinales = GetWedstrijdForKnockoutId(3);

            finale.TeamThuis = halveFinales[0].Winnaar;
            finale.TeamUit = halveFinales[1].Winnaar;

            troostFinale.TeamThuis = halveFinales[0].Verliezer;
            troostFinale.TeamUit = halveFinales[1].Verliezer;
        }

        #region Helper Functions
        private (List<Team> eerstePlaatsen, List<Team> tweedePlaatsen) GetAchtsteFinalisten()
        {
            List<Team> eerstePlaatsen = new List<Team>();
            List<Team> tweedePlaatsen = new List<Team>();

            List<Team> alleTeams = _context.Teams
                    .Include(t => t.ThuisWedstrijden)
                    .Include(t => t.UitWedstrijden).ToList();

            alleTeams = alleTeams
                .OrderBy(t => t.Doelsaldo)
                .OrderBy(t => t.Punten)
                .Reverse()
                .ToList();

            foreach (var poule in _context.Poules)
            {
                List<Team> teams = alleTeams.Where(t => t.PouleID == poule.ID).ToList();
                eerstePlaatsen.AddRange(teams.GetRange(0, 1));
                tweedePlaatsen.AddRange(teams.GetRange(1, 1));
            }

            return (eerstePlaatsen, tweedePlaatsen);
        }

        private List<Wedstrijd> GetWedstrijdForKnockoutId(int id)
        {
            return _context.Wedstrijden.OrderBy(w => w.Datum).Where(w => w.KnockoutID == id).ToList();
        }

        private void UpdateWedstrijden(List<Wedstrijd> wedstrijden)
        {
            foreach (var wedstrijd in wedstrijden)
            {
                _context.Update(wedstrijd);
            }

            _context.SaveChanges();
        }

        #endregion
    }
}

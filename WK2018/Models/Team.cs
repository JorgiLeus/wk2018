using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public string Naam { get; set; }

        public int PouleID { get; set; }
        public Poule Poule { get; set; }

        public ICollection<Speler> Spelers { get; set; }

        [InverseProperty("TeamThuis")]
        public ICollection<Wedstrijd> ThuisWedstrijden { get; set; }
        [InverseProperty("TeamUit")]
        public ICollection<Wedstrijd> UitWedstrijden { get; set; }

        private ICollection<Wedstrijd> ThuisWedstrijdenInGroepsfase => ThuisWedstrijden?.Where(w => w.KnockoutID == null).ToList() ?? new List<Wedstrijd>();
        private ICollection<Wedstrijd> UitWedstrijdenInGroepsfase => UitWedstrijden?.Where(w => w.KnockoutID == null).ToList() ?? new List<Wedstrijd>();

        #region Calculated Fields
        public int Punten => AantalGewonnenWedstrijden * 3 + AantalGelijkeWedstrijden;

        // Gebruik van ? om if != null te vermijden
        private int GespeeldeThuisWedstrijden => ThuisWedstrijdenInGroepsfase?.Where(t => t.ScoreThuis != null).Count() ?? 0;
        private int GespeeldeUitWedstrijden => UitWedstrijdenInGroepsfase?.Where(t => t.ScoreThuis != null).Count() ?? 0;
        public int GespeeldeWedstrijden => GespeeldeThuisWedstrijden + GespeeldeUitWedstrijden;

        private int GewonnenThuisWedstrijden => ThuisWedstrijdenInGroepsfase?.Where(w => w.ScoreThuis > w.ScoreUit).Count() ?? 0;
        private int GewonnenUitWedstrijden => UitWedstrijdenInGroepsfase?.Where(w => w.ScoreUit > w.ScoreThuis).Count() ?? 0;
        public int AantalGewonnenWedstrijden => GewonnenThuisWedstrijden + GewonnenUitWedstrijden;

        private int GelijkeThuisWedstrijden => ThuisWedstrijdenInGroepsfase?.Where(w => w.ScoreThuis == w.ScoreUit && w.ScoreThuis != null).Count() ?? 0;
        private int GelijkeUitWedstrijden => UitWedstrijdenInGroepsfase?.Where(w => w.ScoreUit == w.ScoreThuis && w.ScoreThuis != null).Count() ?? 0;
        public int AantalGelijkeWedstrijden => GelijkeThuisWedstrijden + GelijkeUitWedstrijden;

        private int VerlorenThuisWedstrijden => ThuisWedstrijdenInGroepsfase?.Where(w => w.ScoreThuis < w.ScoreUit).Count() ?? 0;
        private int VerlorenUitWedstrijden => UitWedstrijdenInGroepsfase?.Where(w => w.ScoreUit < w.ScoreThuis).Count() ?? 0;
        public int AantalVerlorenWedstrijden => VerlorenThuisWedstrijden + VerlorenUitWedstrijden;

        private int AantalDoelpuntenVoorUit => UitWedstrijdenInGroepsfase?.Select(w => w.ScoreUit).ToList().Sum() ?? 0;
        private int AantalDoelpuntenVoorThuis => ThuisWedstrijdenInGroepsfase?.Select(w => w.ScoreThuis).ToList().Sum() ?? 0;
        public int DoelpuntenVoor => AantalDoelpuntenVoorThuis + AantalDoelpuntenVoorUit;

        private int AantalDoelpuntenTegenUit => UitWedstrijdenInGroepsfase?.Select(w => w.ScoreThuis).ToList().Sum() ?? 0;
        private int AantalDoelpuntenTegenThuis => ThuisWedstrijdenInGroepsfase?.Select(w => w.ScoreUit).ToList().Sum() ?? 0;
        public int DoelpuntenTegen => AantalDoelpuntenTegenThuis + AantalDoelpuntenTegenUit;

        public int Doelsaldo => DoelpuntenVoor - DoelpuntenTegen;
        #endregion
    }
}

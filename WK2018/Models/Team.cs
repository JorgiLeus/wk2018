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
        [Required]
        public int Punten => AantalGewonnenWedstrijden * 3 + AantalGelijkeWedstrijden;

        public int PouleID { get; set; }
        public Poule Poule { get; set; }

        public int? KnockoutID { get; set; }
        public Knockout Knockout { get; set; }

        public ICollection<Speler> Spelers { get; set; }

        [InverseProperty("TeamThuis")]
        public ICollection<Wedstrijd> ThuisWedstrijden { get; set; }
        [InverseProperty("TeamUit")]
        public ICollection<Wedstrijd> UitWedstrijden { get; set; }

        #region Calculated Fields

        // Gebruik van ? om if != null te vermijden
        private int GespeeldeThuisWedstrijden => ThuisWedstrijden?.Where(t => t.ScoreThuis != null).Count() ?? 0;
        private int GespeeldeUitWedstrijden => UitWedstrijden?.Where(t => t.ScoreThuis != null).Count() ?? 0;
        public int GespeeldeWedstrijden => GespeeldeThuisWedstrijden + GespeeldeUitWedstrijden;

        private int GewonnenThuisWedstrijden => ThuisWedstrijden?.Where(w => w.ScoreThuis > w.ScoreUit).Count() ?? 0;
        private int GewonnenUitWedstrijden => UitWedstrijden?.Where(w => w.ScoreUit > w.ScoreThuis).Count() ?? 0;
        public int AantalGewonnenWedstrijden => GewonnenThuisWedstrijden + GewonnenUitWedstrijden;

        private int GelijkeThuisWedstrijden => ThuisWedstrijden?.Where(w => w.ScoreThuis == w.ScoreUit && w.ScoreThuis != null).Count() ?? 0;
        private int GelijkeUitWedstrijden => UitWedstrijden?.Where(w => w.ScoreUit == w.ScoreThuis && w.ScoreThuis != null).Count() ?? 0;
        public int AantalGelijkeWedstrijden => GelijkeThuisWedstrijden + GelijkeUitWedstrijden;

        private int VerlorenThuisWedstrijden => ThuisWedstrijden?.Where(w => w.ScoreThuis < w.ScoreUit).Count() ?? 0;
        private int VerlorenUitWedstrijden => UitWedstrijden?.Where(w => w.ScoreUit < w.ScoreThuis).Count() ?? 0;
        public int AantalVerlorenWedstrijden => VerlorenThuisWedstrijden + VerlorenUitWedstrijden;

        private int AantalDoelpuntenVoorUit => UitWedstrijden?.Select(w => w.ScoreUit).ToList().Sum() ?? 0;
        private int AantalDoelpuntenVoorThuis => ThuisWedstrijden?.Select(w => w.ScoreThuis).ToList().Sum() ?? 0;
        public int DoelpuntenVoor => AantalDoelpuntenVoorThuis + AantalDoelpuntenVoorUit;

        private int AantalDoelpuntenTegenUit => UitWedstrijden?.Select(w => w.ScoreThuis).ToList().Sum() ?? 0;
        private int AantalDoelpuntenTegenThuis => ThuisWedstrijden?.Select(w => w.ScoreUit).ToList().Sum() ?? 0;
        public int DoelpuntenTegen => AantalDoelpuntenTegenThuis + AantalDoelpuntenTegenUit;

        public int Doelsaldo => DoelpuntenVoor - DoelpuntenTegen;
        #endregion
    }
}

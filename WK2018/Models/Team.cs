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
        public int ID { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public int Punten { get; set; }
        [Required]
        public int Poule_ID { get; set; }
        public Poule Poule { get; set; }
        public int? Knockout_ID { get; set; }
        public Knockout KnockoutStage { get; set; }
        public ICollection<Speler> Spelers { get; set; }

        [InverseProperty("Team_Thuis")]
        public ICollection<Wedstrijd> ThuisWedstrijden { get; set; }
        
        [InverseProperty("Team_Uit")]
        public ICollection<Wedstrijd> UitWedstrijden { get; set; }

        public ICollection<Wedstrijd> Wedstrijden
        {
            get
            {
                return ThuisWedstrijden?.Concat(UitWedstrijden).ToList();
            }
        }

        public int GespeeldeWedstrijden
        {
            get
            {
                return Wedstrijden?.Select(w => w.Gespeeld).Count() ?? 0;
            }
        }

        public int AantalGewonnenWedstrijden
        {
            get
            {
                int gewonnenThuis = ThuisWedstrijden?.Select(w => w.Score.Thuis > w.Score.Uit).Count() ?? 0;
                int gewonnenUit = UitWedstrijden?.Select(w => w.Score.Uit > w.Score.Thuis).Count() ?? 0;

                return gewonnenThuis + gewonnenUit;
            }
        }

        public int AantalVerlorenWedstrijden
        {
            get
            {
                int verlorenThuis = ThuisWedstrijden?.Select(w => w.Score.Thuis < w.Score.Uit).Count() ?? 0;
                int verlorenUit = UitWedstrijden?.Select(w => w.Score.Uit > w.Score.Thuis).Count() ?? 0;

                return verlorenThuis + verlorenUit;
            }
        }

        public int AantalGelijkeWedstrijden
        {
            get
            {
                return Wedstrijden?.Select(w => w.Score.Thuis == w.Score.Uit).Count() ?? 0;
            }
        }

        public int DoelpuntenTegen
        {
            get
            {
                int doelpuntenTegen = 0;
                if (ThuisWedstrijden != null)
                {
                    foreach (var wedstrijd in ThuisWedstrijden)
                    {
                        doelpuntenTegen += wedstrijd.Score.Uit;
                    }
                }

                if (UitWedstrijden != null)
                {
                    foreach (var wedstrijd in UitWedstrijden)
                    {
                        doelpuntenTegen += wedstrijd.Score.Thuis;
                    }
                }

                return doelpuntenTegen;
            }
        }

        public int DoelpuntenVoor
        {
            get
            {
                int doepuntenVoor = 0;
                if (ThuisWedstrijden != null)
                {
                    foreach (var wedstrijd in ThuisWedstrijden)
                    {
                        doepuntenVoor += wedstrijd.Score.Thuis;
                    }
                }

                if (UitWedstrijden != null)
                {
                    foreach (var wedstrijd in UitWedstrijden)
                    {
                        doepuntenVoor += wedstrijd.Score.Uit;
                    }
                }

                return doepuntenVoor;
            }
        }

        public int Doelsaldo
        {
            get
            {
                return DoelpuntenVoor - DoelpuntenTegen;
            }
        }
    }
}

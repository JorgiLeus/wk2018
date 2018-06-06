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
        public int Punten { get; set; }

        public int PouleID { get; set; }
        public Poule Poule { get; set; }

        public int? KnockoutID { get; set; }
        public Knockout Knockout { get; set; }

        public ICollection<Speler> Spelers { get; set; }

        [InverseProperty("TeamThuis")]
        public ICollection<Wedstrijd> ThuisWedstrijden { get; set; }
        [InverseProperty("TeamUit")]
        public ICollection<Wedstrijd> UitWedstrijden { get; set; }
        //public ICollection<Wedstrijd> Wedstrijden => ThuisWedstrijden.Concat(UitWedstrijden).ToList();

        public int GespeeldeWedstrijden
        {
            get
            {
                return 0;
            }
        }

        public int AantalGewonnenWedstrijden => 0;

        public int AantalGelijkeWedstrijden => 0;

        public int AantalVerlorenWedstrijden => 0;

        public int DoelpuntenVoor => 0;

        public int DoelpuntenTegen => 0;

        public int Doelsaldo => 0;

    }
}

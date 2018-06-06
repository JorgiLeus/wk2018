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
    }
}

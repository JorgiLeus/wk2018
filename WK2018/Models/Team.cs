using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public ICollection<Wedstrijd> Wedstrijden { get; set; }
    }
}
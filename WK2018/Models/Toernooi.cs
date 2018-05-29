using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Toernooi
    {
        public int ID { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]

        public ICollection<Poule> Poules { get; set; }
        public ICollection<Knockout> KnockoutStages { get; set; }
    }
}

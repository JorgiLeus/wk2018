using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Toernooi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public string Naam { get; set; }
       

        public ICollection<Poule> Poules { get; set; }
        public ICollection<Knockout> KnockoutStages { get; set; }
    }
}

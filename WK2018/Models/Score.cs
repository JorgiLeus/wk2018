using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Score
    {
        public int Thuis { get; set; }
        [Required]
        public int Uit { get; set; }
        [Required]

        public ICollection<Wedstrijd> Wedstrijden { get; set; }
    }
}

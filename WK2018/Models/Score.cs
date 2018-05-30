using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Score
    {
        [Key]
        public int Thuis { get; set; }
        [Key]
        public int Uit { get; set; }
        

        public ICollection<Wedstrijd> Wedstrijden { get; set; }
    }
}

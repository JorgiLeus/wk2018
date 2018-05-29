using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Knockout
    {
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]

        public int Toernooi_ID { get; set; }
        [Required]
        public Toernooi Toernooi { get; set; }
        [Required]
        public ICollection<Team> Teams { get; set; }
    }
}

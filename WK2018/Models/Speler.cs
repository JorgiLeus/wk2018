using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Speler
    {
        public int ID { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public int WG { get; set; }
        [Required]
        public int GK { get; set; }
        [Required]
        public int RK { get; set; }
        [Required]
        public int DP { get; set; }
        [Required]
        public string Positie { get; set; }
        [Required]
        public DateTime GeboorteDatum { get; set; }
        [Required]

        public int Team_ID { get; set; }
        [Required]
        public Team Team { get; set; }
        [Required]
    }
}

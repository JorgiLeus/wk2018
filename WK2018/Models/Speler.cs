using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Speler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public string Naam { get; set; }
        public int WG { get; set; }
        public int GK { get; set; }
        public int RK { get; set; }
        public int DP { get; set; }
        public string Positie { get; set; }
        public DateTime GeboorteDatum { get; set; }

        [Required]
        public int TeamID { get; set; }
        public Team Team { get; set; }
       
    }
}

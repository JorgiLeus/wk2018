using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Wedstrijd
    {
        public int ID { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]

        public Boolean Gespeeld { get; set; }

        public int? Poule_ID { get; set; }
        public Poule Poule { get; set; }
        public int? Knockout_ID { get; set; }
        public Knockout Knockout { get; set; }

        public int Score_Thuis { get; set; }
        public int Score_Uit { get; set; }
        public Score Score { get; set; }
        public int Team_Thuis_ID { get; set; }
        public Team Team_Thuis { get; set; }
        public int Team_Uit_ID { get; set; }
        public Team Team_Uit { get; set; }
    }
}

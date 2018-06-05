using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Wedstrijd
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]

        public int Score_Thuis { get; set; }
        public int Score_Uit { get; set; }
        public Score Score { get; set; }
        public int Team_Thuis_ID { get; set; }
        public Team Team_Thuis { get; set; }
        public int Team_Uit_ID { get; set; }
        public Team Team_Uit { get; set; }
    }
}

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

        public int? ScoreThuis { get; set; }
        public int? ScoreUit { get; set; }

        public int? KnockoutID { get; set; }
        public Knockout Knockout { get; set; }

        [ForeignKey("TeamThuis")]
        public int? TeamThuisID { get; set; }

        public Team TeamThuis { get; set; }

        [ForeignKey("TeamUit")]
        public int? TeamUitID { get; set; }

        public Team TeamUit { get; set; }

        public Team Winnaar => ScoreThuis > ScoreUit ? TeamThuis : TeamUit;

        public Team Verliezer => ScoreUit > ScoreThuis ? TeamThuis : TeamUit;

        public bool IsGelijkSpel => ScoreThuis == ScoreUit;
    }
}

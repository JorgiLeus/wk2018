﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models
{
    public class Knockout
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]

        public int ToernooiID { get; set; }
        [Required]
        public Toernooi Toernooi { get; set; }

        public ICollection<Wedstrijd> Wedstrijden { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models.PouleViewModels
{
    public class DetailViewModel
    {
        public Poule Poule { get; set; }

        public ICollection<Wedstrijd> Wedstrijden { get; set; }
    }
}

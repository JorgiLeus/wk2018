using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models.KnockoutViewModels
{
    public class IndexKnockoutViewModel
    {
        public List<Knockout> KnockoutStages { get; set; }

        public Dictionary<String, List<Wedstrijd>> KnockoutWedstrijden { get; set; }
    }
}

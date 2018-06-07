using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Models;

namespace WK2018.Areas.Admin.Models.TeamViewModel
{
    public class SpelerViewModel
    {
        public Speler Speler { get; set; }
        public int WG { get; set; }
        public int GK { get; set; }
        public int RK { get; set; }
        public int DP { get; set; }
    }
}

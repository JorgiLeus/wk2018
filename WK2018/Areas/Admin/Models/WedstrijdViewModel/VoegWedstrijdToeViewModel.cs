using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Models;

namespace WK2018.Areas.Admin.Models.WedstrijdViewModel
{
    public class VoegWedstrijdToeViewModel
    {
        public SelectList LijstTeamThuis { get; set; }
        public int TeamThuisID { get; set; }
        public SelectList LijstTeamUit { get; set; }
        public int TeamUitID { get; set; }
        public Wedstrijd Wedstrijd { get; set; }
    }
}

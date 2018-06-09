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
        public Wedstrijd Wedstrijd { get; set; }

        public SelectList Thuisteams { get; set; }
        public SelectList Uitteams { get; set; }
    }
}

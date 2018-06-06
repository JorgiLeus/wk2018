using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WK2018.Models.PouleViewModels
{
    public class DetailViewModel
    {
        public Poule Poule { get; set; }

        public ICollection<Wedstrijd> Wedstrijden
        {
            get
            {
                List<ICollection<Wedstrijd>> collectionWedstrijden = Poule.Teams.Select(t => t.ThuisWedstrijden).ToList();
                List<Wedstrijd> wedstrijden = new List<Wedstrijd>();

                foreach (var collection in collectionWedstrijden)
                {
                    if (collection != null)
                    {
                        foreach (var wedstrijd in collection)
                        {
                            wedstrijden.Add(wedstrijd);
                        }
                    }
                }

                return wedstrijden.Distinct().ToList();
            }
        }
    }
}

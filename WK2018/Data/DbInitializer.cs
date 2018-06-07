using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WK2018.Models;

namespace WK2018.Data
{
    public class DbInitializer
    {
        public static void Initialize(WKContext context)
        {
            context.Database.EnsureCreated();

            //Look for any tournaments
            if (context.Toernooien.Any())
            {
                return; //DB has been seeded
            }

            new List<Toernooi>
            {
                new Toernooi{ ID=1, Naam="WK 2018"}
            }.ForEach(t => context.Toernooien.Add(t));

            context.SaveChanges();

            new List<Poule>
            {
                new Poule { ID=1, Naam='A', ToernooiID=1 },
                new Poule { ID=2, Naam='B', ToernooiID=1 },
                new Poule { ID=3, Naam='C', ToernooiID=1 },
                new Poule { ID=4, Naam='D', ToernooiID=1 },
                new Poule { ID=5, Naam='E', ToernooiID=1 },
                new Poule { ID=6, Naam='F', ToernooiID=1 },
                new Poule { ID=7, Naam='G', ToernooiID=1 },
                new Poule { ID=8, Naam='H', ToernooiID=1 },
            }.ForEach(p => context.Poules.Add(p));

            context.SaveChanges();

            new List<Knockout>
            {
                new Knockout { ID=1, Type="1/8e Finale", ToernooiID=1},
                new Knockout { ID=2, Type="Kwart finale", ToernooiID=1},
                new Knockout { ID=3, Type="Halve finale", ToernooiID=1},
                new Knockout { ID=4, Type="Troostfinale", ToernooiID=1},
                new Knockout { ID=5, Type="Finale", ToernooiID=1},
            }.ForEach(k => context.KnockoutStages.Add(k));

            context.SaveChanges();

            new List<Team>
            {
                new Team { ID=1, Naam="Rusland", PouleID=1 },
                new Team { ID=2, Naam="Saudi-Arabië", PouleID=1 },
                new Team { ID=3, Naam="Egypte", PouleID=1 },
                new Team { ID=4, Naam="Uruguay", PouleID=1 },
                new Team { ID=5, Naam="Portugal", PouleID=2 },
                new Team { ID=6, Naam="Spanje", PouleID=2 },
                new Team { ID=7, Naam="Marokko", PouleID=2 },
                new Team { ID=8, Naam="Iran", PouleID=2 },
                new Team { ID=9, Naam="Frankrijk", PouleID=3 },
                new Team { ID=10, Naam="Australië", PouleID=3 },
                new Team { ID=11, Naam="Peru", PouleID=3 },
                new Team { ID=12, Naam="Denemaken", PouleID=3 },
                new Team { ID=13, Naam="Argentinië", PouleID=4 },
                new Team { ID=14, Naam="IJsland", PouleID=4 },
                new Team { ID=15, Naam="Kroatië", PouleID=4 },
                new Team { ID=16, Naam="Nigeria", PouleID=4 },
                new Team { ID=17, Naam="Brazilië", PouleID=5 },
                new Team { ID=18, Naam="Zwitserland", PouleID=5 },
                new Team { ID=19, Naam="Costa Rica", PouleID=5 },
                new Team { ID=20, Naam="Servië", PouleID=5 },
                new Team { ID=21, Naam="Duitsland", PouleID=6 },
                new Team { ID=22, Naam="Mexico", PouleID=6 },
                new Team { ID=23, Naam="Zweden", PouleID=6 },
                new Team { ID=24, Naam="Zuid-Korea", PouleID=6 },
                new Team { ID=25, Naam="België", PouleID=7 },
                new Team { ID=26, Naam="Panama", PouleID=7 },
                new Team { ID=27, Naam="Tunesië", PouleID=7 },
                new Team { ID=28, Naam="Engeland", PouleID=7 },
                new Team { ID=29, Naam="Polen", PouleID=8 },
                new Team { ID=30, Naam="Senegal", PouleID=8 },
                new Team { ID=31, Naam="Colombia", PouleID=8 },
                new Team { ID=32, Naam="Japan", PouleID=8 },
            }.ForEach(t => context.Teams.Add(t));

            context.SaveChanges();

            new List<Speler>{
                new Speler{ ID=1, Naam="Igor Akinfejev", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-04-08"), Positie="DM", TeamID=1},
                new Speler{ ID=2, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", TeamID=2},
                new Speler{ ID=3, Naam="Mohamed Salah", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-06-15"), Positie="RB", TeamID=3},
                new Speler{ ID=4, Naam="Edinson Cavani", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-02-14"), Positie="SP", TeamID=4},
                new Speler{ ID=5, Naam="Cristiano Ronaldo", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-02-05"), Positie="CV", TeamID=5},
                new Speler{ ID=6, Naam="David Silva", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-01-08"), Positie="CAM", TeamID=6},
                new Speler{ ID=7, Naam="Mehdi Benatia", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-04-17"), Positie="CV", TeamID=7},
                new Speler{ ID=8, Naam="Jalal Hosseini", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1982-02-03"), Positie="CV", TeamID=8},
                new Speler{ ID=9, Naam="Hugo Lloris", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-12-26"), Positie="DM", TeamID=9},
                new Speler{ ID=10, Naam="Tim Cahill", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1979-12-06"), Positie="CAM", TeamID=10},
                new Speler{ ID=11, Naam="Juan Manuel Vargas", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-10-05"), Positie="SP", TeamID=11},
                new Speler{ ID=12, Naam="Daniel Agger", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-12-12"), Positie="CV", TeamID=12},
                new Speler{ ID=13, Naam="Lionel Messi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-06-24"), Positie="SP", TeamID=13},
                new Speler{ ID=14, Naam="Birkir Bjarnason", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-05-27"), Positie="CM", TeamID=14},
                new Speler{ ID=15, Naam="Darijo Srna", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1982-05-01"), Positie="RV", TeamID=15},
                new Speler{ ID=16, Naam="Daniel Akpeyi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-08-03"), Positie="DM", TeamID=16},
                new Speler{ ID=17, Naam="Thiago Silva", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-09-22"), Positie="CV", TeamID=17},
                new Speler{ ID=18, Naam="Yann Sommer", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-12-17"), Positie="DM", TeamID=18},
                new Speler{ ID=19, Naam="Bryan Ruiz", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-08-18"), Positie="LB", TeamID=19},
                new Speler{ ID=20, Naam="Branislav Ivanovic", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-02-22"), Positie="RV", TeamID=20},
                new Speler{ ID=21, Naam="Marco Reus", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-05-31"), Positie="LM", TeamID=21},
                new Speler{ ID=22, Naam="Javier Hernández", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-06-01"), Positie="SP", TeamID=22},
                new Speler{ ID=23, Naam="Marcus Berg", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-08-17"), Positie="SP", TeamID=23},
                new Speler{ ID=24, Naam="Kim Young-gwon", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1990-02-27"), Positie="CV", TeamID=24},
                new Speler{ ID=25, Naam="Thibaut Courtois", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-05-11"), Positie="CV", TeamID=25},
                new Speler{ ID=26, Naam="Toby Alderweireld", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-03-02"), Positie="CV", TeamID=25},
                new Speler{ ID=27, Naam="Michy Batshuayi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-10-02"), Positie="CV", TeamID=25},
                new Speler{ ID=28, Naam="Christian Benteke", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1990-12-03"), Positie="CV", TeamID=25},
                new Speler{ ID=29, Naam="Dedryck Boyata", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1990-11-28"), Positie="CV", TeamID=25},
                new Speler{ ID=30, Naam="Yannick Carrasco", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-09-04"), Positie="CV", TeamID=25},
                new Speler{ ID=31, Naam="Koen Casteels", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-06-25"), Positie="CV", TeamID=25},
                new Speler{ ID=32, Naam="Nacer Chadli", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-08-02"), Positie="CV", TeamID=25},
                new Speler{ ID=33, Naam="Laurent Ciman", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-08-05"), Positie="CV", TeamID=25},
                new Speler{ ID=34, Naam="Kevin De Bruyne", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-06-28"), Positie="CV", TeamID=25},
                new Speler{ ID=35, Naam="Mousa Dembélé", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-07-16"), Positie="CV", TeamID=25},
                new Speler{ ID=36, Naam="Leander Dendoncker", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1995-04-15"), Positie="CV", TeamID=25},
                new Speler{ ID=37, Naam="Marouane Fellaine", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-11-22"), Positie="CV", TeamID=25},
                new Speler{ ID=38, Naam="Eden Hazard", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-01-07"), Positie="CV", TeamID=25},
                new Speler{ ID=39, Naam="Thorgan Hazard", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-03-29"), Positie="CV", TeamID=25},
                new Speler{ ID=40, Naam="Adnan Januzaj", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1995-02-05"), Positie="CV", TeamID=25},
                new Speler{ ID=41, Naam="Christian Kabasele", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-02-24"), Positie="CV", TeamID=25},
                new Speler{ ID=42, Naam="Vincent Kompany", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-04-10"), Positie="CV", TeamID=25},
                new Speler{ ID=43, Naam="Jordan Lukaku", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1994-07-25"), Positie="CV", TeamID=25},
                new Speler{ ID=44, Naam="Romelu Lukaku", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-05-13"), Positie="CV", TeamID=25},
                new Speler{ ID=45, Naam="Dries Mertens", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-05-06"), Positie="CV", TeamID=25},
                new Speler{ ID=46, Naam="Thomas Meunier", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-09-12"), Positie="CV", TeamID=25},
                new Speler{ ID=47, Naam="Simon Mignolet", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-03-06"), Positie="CV", TeamID=25},
                new Speler{ ID=48, Naam="Matz Sels", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-02-26"), Positie="CV", TeamID=25},
                new Speler{ ID=49, Naam="Youri Tielemans", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1997-05-07"), Positie="CV", TeamID=25},
                new Speler{ ID=50, Naam="Thomas Vermaelen", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-11-14"), Positie="CV", TeamID=25},
                new Speler{ ID=51, Naam="Jan Verthongen", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-04-24"), Positie="CV", TeamID=25},
                new Speler{ ID=52, Naam="Axel Witsel", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-01-12"), Positie="CV", TeamID=25},
                new Speler{ ID=53, Naam="Gabriel Torres", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-10-31"), Positie="SP", TeamID=26},
                new Speler{ ID=54, Naam="Jamel Saihi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-01-21"), Positie="CVM", TeamID=27},
                new Speler{ ID=55, Naam="Harry Kane", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-07-28"), Positie="CAM", TeamID=28},
                new Speler{ ID=56, Naam="Robert Lewandowski", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-08-21"), Positie="SP", TeamID=29},
                new Speler{ ID=57, Naam="Kara Mbodj", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-11-11"), Positie="CV", TeamID=30},
                new Speler{ ID=58, Naam="James Rodríguez", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-07-12"), Positie="RB", TeamID=31},
                new Speler{ ID=59, Naam="Makoto Hasebe", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-01-18"), Positie="CVM", TeamID=32},
            }.ForEach(s => context.Spelers.Add(s));

            context.SaveChanges();


            new List<Wedstrijd>
            {
                new Wedstrijd { ID=1, Datum= DateTime.Parse("14/06/2018 17:00:00"),  TeamThuisID=1, TeamUitID=2},
                new Wedstrijd { ID=2, Datum= DateTime.Parse("15/06/2018 14:00:00"),  TeamThuisID=3, TeamUitID=4},
                new Wedstrijd { ID=3, Datum= DateTime.Parse("19/06/2018 20:00:00"),  TeamThuisID=1, TeamUitID=3},
                new Wedstrijd { ID=4, Datum= DateTime.Parse("20/06/2018 17:00:00"),  TeamThuisID=4, TeamUitID=3},
                new Wedstrijd { ID=5, Datum= DateTime.Parse("25/06/2018 16:00:00"),  TeamThuisID=4, TeamUitID=1},
                new Wedstrijd { ID=6, Datum= DateTime.Parse("25/06/2018 16:00:00"),  TeamThuisID=2, TeamUitID=3},
            }.ForEach(w => context.Wedstrijden.Add(w));

            context.SaveChanges();
        }
    }
}
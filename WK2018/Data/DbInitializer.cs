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
                new Poule { ID=1, Naam='A', Toernooi_ID=1 },
                new Poule { ID=2, Naam='B', Toernooi_ID=1 },
                new Poule { ID=3, Naam='C', Toernooi_ID=1 },
                new Poule { ID=4, Naam='D', Toernooi_ID=1 },
                new Poule { ID=5, Naam='E', Toernooi_ID=1 },
                new Poule { ID=6, Naam='F', Toernooi_ID=1 },
                new Poule { ID=7, Naam='G', Toernooi_ID=1 },
                new Poule { ID=8, Naam='H', Toernooi_ID=1 },
            }.ForEach(p => context.Poules.Add(p));

            new List<Knockout>
            {
                new Knockout { ID=1, Type="1/8e Finale", Toernooi_ID=1},
                new Knockout { ID=2, Type="Kwart finale", Toernooi_ID=1},
                new Knockout { ID=3, Type="Halve finale", Toernooi_ID=1},
                new Knockout { ID=4, Type="Troostfinale", Toernooi_ID=1},
                new Knockout { ID=5, Type="Finale", Toernooi_ID=1},
            }.ForEach(k => context.KnockoutStages.Add(k));

            new List<Team>
            {
                new Team { ID=1, Naam="Rusland", Punten=0, Poule_ID=1 },
                new Team { ID=2, Naam="Saudi-Arabië", Punten=0, Poule_ID=1 },
                new Team { ID=3, Naam="Egypte", Punten=0, Poule_ID=1 },
                new Team { ID=4, Naam="Uruguay", Punten=0, Poule_ID=1 },
                new Team { ID=5, Naam="Portugal", Punten=0, Poule_ID=2 },
                new Team { ID=6, Naam="Spanje", Punten=0, Poule_ID=2 },
                new Team { ID=7, Naam="Marokko", Punten=0, Poule_ID=2 },
                new Team { ID=8, Naam="Iran", Punten=0, Poule_ID=2 },
                new Team { ID=9, Naam="Frankrijk", Punten=0, Poule_ID=3 },
                new Team { ID=10, Naam="Australië", Punten=0, Poule_ID=3 },
                new Team { ID=11, Naam="Peru", Punten=0, Poule_ID=3 },
                new Team { ID=12, Naam="Denemarken", Punten=0, Poule_ID=3 },
                new Team { ID=13, Naam="Argentinië", Punten=0, Poule_ID=4 },
                new Team { ID=14, Naam="IJsland", Punten=0, Poule_ID=4 },
                new Team { ID=15, Naam="Kroatië", Punten=0, Poule_ID=4 },
                new Team { ID=16, Naam="Nigeria", Punten=0, Poule_ID=4 },
                new Team { ID=17, Naam="Brazilië", Punten=0, Poule_ID=5 },
                new Team { ID=18, Naam="Zwitserland", Punten=0, Poule_ID=5 },
                new Team { ID=19, Naam="Costa Rica", Punten=0, Poule_ID=5 },
                new Team { ID=20, Naam="Servië", Punten=0, Poule_ID=5 },
                new Team { ID=21, Naam="Duitsland", Punten=0, Poule_ID=6 },
                new Team { ID=22, Naam="Mexico", Punten=0, Poule_ID=6 },
                new Team { ID=23, Naam="Zweden", Punten=0, Poule_ID=6 },
                new Team { ID=24, Naam="Zuid-Korea", Punten=0, Poule_ID=6 },
                new Team { ID=25, Naam="België", Punten=0, Poule_ID=7 },
                new Team { ID=26, Naam="Panama", Punten=0, Poule_ID=7 },
                new Team { ID=27, Naam="Tunesië", Punten=0, Poule_ID=7 },
                new Team { ID=28, Naam="Engeland", Punten=0, Poule_ID=7 },
                new Team { ID=29, Naam="Polen", Punten=0, Poule_ID=8 },
                new Team { ID=30, Naam="Senegal", Punten=0, Poule_ID=8 },
                new Team { ID=31, Naam="Colombia", Punten=0, Poule_ID=8 },
                new Team { ID=32, Naam="Japan", Punten=0, Poule_ID=8 },
            }.ForEach(t => context.Teams.Add(t));

            new List<Speler>{
                new Speler{ ID=1, Naam="Igor Akinfejev", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-04-08"), Positie="DM", Team_ID=1},
                new Speler{ ID=2, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=2},
                new Speler{ ID=3, Naam="Mohamed Salah", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-06-15"), Positie="RB", Team_ID=3},
                new Speler{ ID=4, Naam="Edinson Cavani", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-02-14"), Positie="SP", Team_ID=4},
                new Speler{ ID=5, Naam="Cristiano Ronaldo", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-02-05"), Positie="CV", Team_ID=5},
                new Speler{ ID=6, Naam="David Silva", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-01-08"), Positie="CAM", Team_ID=6},
                new Speler{ ID=7, Naam="Mehdi Benatia", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-04-17"), Positie="CV", Team_ID=7},
                new Speler{ ID=8, Naam="Jalal Hosseini", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1982-02-03"), Positie="CV", Team_ID=8},
                new Speler{ ID=9, Naam="Hugo Lloris", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-12-26"), Positie="DM", Team_ID=9},
                new Speler{ ID=10, Naam="Tim Cahill", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1979-12-06"), Positie="CAM", Team_ID=10},
                new Speler{ ID=11, Naam="Juan Manuel Vargas", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-10-05"), Positie="SP", Team_ID=11},
                new Speler{ ID=12, Naam="Daniel Agger", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-12-12"), Positie="CV", Team_ID=12},
                new Speler{ ID=13, Naam="Lionel Messi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-06-24"), Positie="SP", Team_ID=13},
                new Speler{ ID=14, Naam="Birkir Bjarnason", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-05-27"), Positie="CM", Team_ID=14},
                new Speler{ ID=15, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=15},
                new Speler{ ID=16, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=16},
                new Speler{ ID=17, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=17},
                new Speler{ ID=18, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=18},
                new Speler{ ID=19, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=19},
                new Speler{ ID=20, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=20},
                new Speler{ ID=21, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=21},
                new Speler{ ID=22, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=22},
                new Speler{ ID=23, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=23},
                new Speler{ ID=24, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=24},
                new Speler{ ID=25, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=26, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=27, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=28, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=29, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=30, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=31, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=32, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=33, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=34, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=35, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=36, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=37, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=38, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=39, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=40, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=41, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=42, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=43, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=44, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=45, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=46, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=47, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=48, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=49, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=50, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=51, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=52, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=25},
                new Speler{ ID=53, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=26},
                new Speler{ ID=54, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=27},
                new Speler{ ID=55, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=28},
                new Speler{ ID=56, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=29},
                new Speler{ ID=57, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=30},
                new Speler{ ID=58, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=31},
                new Speler{ ID=59, Naam="Osama Hawsawi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-03-31"), Positie="CV", Team_ID=32},
            }.ForEach(s => context.Spelers.Add(s));
        }
    }
}
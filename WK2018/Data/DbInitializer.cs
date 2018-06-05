﻿using System;
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
                new Poule { ID=1, Naam="A", Toernooi_ID=1 },
                new Poule { ID=2, Naam="B", Toernooi_ID=1 },
                new Poule { ID=3, Naam="C", Toernooi_ID=1 },
                new Poule { ID=4, Naam="D", Toernooi_ID=1 },
                new Poule { ID=5, Naam="E", Toernooi_ID=1 },
                new Poule { ID=6, Naam="F", Toernooi_ID=1 },
                new Poule { ID=7, Naam="G", Toernooi_ID=1 },
                new Poule { ID=8, Naam="H", Toernooi_ID=1 },
            }.ForEach(p => context.Poules.Add(p));

            context.SaveChanges();

            new List<Knockout>
            {
                new Knockout { ID=1, Type="1/8e Finale", Toernooi_ID=1},
                new Knockout { ID=2, Type="Kwart finale", Toernooi_ID=1},
                new Knockout { ID=3, Type="Halve finale", Toernooi_ID=1},
                new Knockout { ID=4, Type="Troostfinale", Toernooi_ID=1},
                new Knockout { ID=5, Type="Finale", Toernooi_ID=1},
            }.ForEach(k => context.KnockoutStages.Add(k));

            context.SaveChanges();

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

            context.SaveChanges();

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
                new Speler{ ID=15, Naam="Darijo Srna", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1982-05-01"), Positie="RV", Team_ID=15},
                new Speler{ ID=16, Naam="Daniel Akpeyi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-08-03"), Positie="DM", Team_ID=16},
                new Speler{ ID=17, Naam="Thiago Silva", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-09-22"), Positie="CV", Team_ID=17},
                new Speler{ ID=18, Naam="Yann Sommer", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-12-17"), Positie="DM", Team_ID=18},
                new Speler{ ID=19, Naam="Bryan Ruiz", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-08-18"), Positie="LB", Team_ID=19},
                new Speler{ ID=20, Naam="Branislav Ivanovic", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-02-22"), Positie="RV", Team_ID=20},
                new Speler{ ID=21, Naam="Marco Reus", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-05-31"), Positie="LM", Team_ID=21},
                new Speler{ ID=22, Naam="Javier Hernández", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-06-01"), Positie="SP", Team_ID=22},
                new Speler{ ID=23, Naam="Marcus Berg", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-08-17"), Positie="SP", Team_ID=23},
                new Speler{ ID=24, Naam="Kim Young-gwon", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1990-02-27"), Positie="CV", Team_ID=24},
                new Speler{ ID=25, Naam="Thibaut Courtois", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-05-11"), Positie="CV", Team_ID=25},
                new Speler{ ID=26, Naam="Toby Alderweireld", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-03-02"), Positie="CV", Team_ID=25},
                new Speler{ ID=27, Naam="Michy Batshuayi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-10-02"), Positie="CV", Team_ID=25},
                new Speler{ ID=28, Naam="Christian Benteke", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1990-12-03"), Positie="CV", Team_ID=25},
                new Speler{ ID=29, Naam="Dedryck Boyata", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1990-11-28"), Positie="CV", Team_ID=25},
                new Speler{ ID=30, Naam="Yannick Carrasco", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-09-04"), Positie="CV", Team_ID=25},
                new Speler{ ID=31, Naam="Koen Casteels", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-06-25"), Positie="CV", Team_ID=25},
                new Speler{ ID=32, Naam="Nacer Chadli", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-08-02"), Positie="CV", Team_ID=25},
                new Speler{ ID=33, Naam="Laurent Ciman", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-08-05"), Positie="CV", Team_ID=25},
                new Speler{ ID=34, Naam="Kevin De Bruyne", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-06-28"), Positie="CV", Team_ID=25},
                new Speler{ ID=35, Naam="Mousa Dembélé", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-07-16"), Positie="CV", Team_ID=25},
                new Speler{ ID=36, Naam="Leander Dendoncker", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1995-04-15"), Positie="CV", Team_ID=25},
                new Speler{ ID=37, Naam="Marouane Fellaine", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-11-22"), Positie="CV", Team_ID=25},
                new Speler{ ID=38, Naam="Eden Hazard", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-01-07"), Positie="CV", Team_ID=25},
                new Speler{ ID=39, Naam="Thorgan Hazard", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-03-29"), Positie="CV", Team_ID=25},
                new Speler{ ID=40, Naam="Adnan Januzaj", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1995-02-05"), Positie="CV", Team_ID=25},
                new Speler{ ID=41, Naam="Christian Kabasele", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-02-24"), Positie="CV", Team_ID=25},
                new Speler{ ID=42, Naam="Vincent Kompany", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1986-04-10"), Positie="CV", Team_ID=25},
                new Speler{ ID=43, Naam="Jordan Lukaku", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1994-07-25"), Positie="CV", Team_ID=25},
                new Speler{ ID=44, Naam="Romelu Lukaku", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-05-13"), Positie="CV", Team_ID=25},
                new Speler{ ID=45, Naam="Dries Mertens", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-05-06"), Positie="CV", Team_ID=25},
                new Speler{ ID=46, Naam="Thomas Meunier", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-09-12"), Positie="CV", Team_ID=25},
                new Speler{ ID=47, Naam="Simon Mignolet", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-03-06"), Positie="CV", Team_ID=25},
                new Speler{ ID=48, Naam="Matz Sels", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1992-02-26"), Positie="CV", Team_ID=25},
                new Speler{ ID=49, Naam="Youri Tielemans", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1997-05-07"), Positie="CV", Team_ID=25},
                new Speler{ ID=50, Naam="Thomas Vermaelen", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1985-11-14"), Positie="CV", Team_ID=25},
                new Speler{ ID=51, Naam="Jan Verthongen", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-04-24"), Positie="CV", Team_ID=25},
                new Speler{ ID=52, Naam="Axel Witsel", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-01-12"), Positie="CV", Team_ID=25},
                new Speler{ ID=53, Naam="Gabriel Torres", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-10-31"), Positie="SP", Team_ID=26},
                new Speler{ ID=54, Naam="Jamel Saihi", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1987-01-21"), Positie="CVM", Team_ID=27},
                new Speler{ ID=55, Naam="Harry Kane", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1993-07-28"), Positie="CAM", Team_ID=28},
                new Speler{ ID=56, Naam="Robert Lewandowski", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1988-08-21"), Positie="SP", Team_ID=29},
                new Speler{ ID=57, Naam="Kara Mbodj", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1989-11-11"), Positie="CV", Team_ID=30},
                new Speler{ ID=58, Naam="James Rodríguez", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1991-07-12"), Positie="RB", Team_ID=31},
                new Speler{ ID=59, Naam="Makoto Hasebe", DP=0, GK=0, RK=0, WG=0, GeboorteDatum=DateTime.Parse("1984-01-18"), Positie="CVM", Team_ID=32},
            }.ForEach(s => context.Spelers.Add(s));

            context.SaveChanges();

            new List<Score>
            {
                new Score { Thuis=00, Uit=00 },
                new Score { Thuis=01, Uit=00 },
                new Score { Thuis=02, Uit=00 },
                new Score { Thuis=03, Uit=00 },
                new Score { Thuis=04, Uit=00 },
                new Score { Thuis=05, Uit=00 },
                new Score { Thuis=06, Uit=00 },
                new Score { Thuis=07, Uit=00 },
                new Score { Thuis=08, Uit=00 },
                new Score { Thuis=09, Uit=00 },
                new Score { Thuis=10, Uit=00 },
                new Score { Thuis=00, Uit=01 },
                new Score { Thuis=01, Uit=01 },
                new Score { Thuis=02, Uit=01 },
                new Score { Thuis=03, Uit=01 },
                new Score { Thuis=04, Uit=01 },
                new Score { Thuis=05, Uit=01 },
                new Score { Thuis=06, Uit=01 },
                new Score { Thuis=07, Uit=01 },
                new Score { Thuis=08, Uit=01 },
                new Score { Thuis=09, Uit=01 },
                new Score { Thuis=10, Uit=01 },
                new Score { Thuis=00, Uit=02 },
                new Score { Thuis=01, Uit=02 },
                new Score { Thuis=02, Uit=02 },
                new Score { Thuis=03, Uit=02 },
                new Score { Thuis=04, Uit=02 },
                new Score { Thuis=05, Uit=02 },
                new Score { Thuis=06, Uit=02 },
                new Score { Thuis=07, Uit=02 },
                new Score { Thuis=08, Uit=02 },
                new Score { Thuis=09, Uit=02 },
                new Score { Thuis=10, Uit=02 },
                new Score { Thuis=00, Uit=03 },
                new Score { Thuis=01, Uit=03 },
                new Score { Thuis=02, Uit=03 },
                new Score { Thuis=03, Uit=03 },
                new Score { Thuis=04, Uit=03 },
                new Score { Thuis=05, Uit=03 },
                new Score { Thuis=06, Uit=03 },
                new Score { Thuis=07, Uit=03 },
                new Score { Thuis=08, Uit=03 },
                new Score { Thuis=09, Uit=03 },
                new Score { Thuis=10, Uit=03 },
                new Score { Thuis=00, Uit=04 },
                new Score { Thuis=01, Uit=04 },
                new Score { Thuis=02, Uit=04 },
                new Score { Thuis=03, Uit=04 },
                new Score { Thuis=04, Uit=04 },
                new Score { Thuis=05, Uit=04 },
                new Score { Thuis=06, Uit=04 },
                new Score { Thuis=07, Uit=04 },
                new Score { Thuis=08, Uit=04 },
                new Score { Thuis=09, Uit=04 },
                new Score { Thuis=10, Uit=04 },
                new Score { Thuis=00, Uit=05 },
                new Score { Thuis=01, Uit=05 },
                new Score { Thuis=02, Uit=05 },
                new Score { Thuis=03, Uit=05 },
                new Score { Thuis=04, Uit=05 },
                new Score { Thuis=05, Uit=05 },
                new Score { Thuis=06, Uit=05 },
                new Score { Thuis=07, Uit=05 },
                new Score { Thuis=08, Uit=05 },
                new Score { Thuis=09, Uit=05 },
                new Score { Thuis=10, Uit=05 },
                new Score { Thuis=00, Uit=06 },
                new Score { Thuis=01, Uit=06 },
                new Score { Thuis=02, Uit=06 },
                new Score { Thuis=03, Uit=06 },
                new Score { Thuis=04, Uit=06 },
                new Score { Thuis=05, Uit=06 },
                new Score { Thuis=06, Uit=06 },
                new Score { Thuis=07, Uit=06 },
                new Score { Thuis=08, Uit=06 },
                new Score { Thuis=09, Uit=06 },
                new Score { Thuis=10, Uit=06 },
                new Score { Thuis=00, Uit=07 },
                new Score { Thuis=01, Uit=07 },
                new Score { Thuis=02, Uit=07 },
                new Score { Thuis=03, Uit=07 },
                new Score { Thuis=04, Uit=07 },
                new Score { Thuis=05, Uit=07 },
                new Score { Thuis=06, Uit=07 },
                new Score { Thuis=07, Uit=07 },
                new Score { Thuis=08, Uit=07 },
                new Score { Thuis=09, Uit=07 },
                new Score { Thuis=10, Uit=07 },
                new Score { Thuis=00, Uit=08 },
                new Score { Thuis=01, Uit=08 },
                new Score { Thuis=02, Uit=08 },
                new Score { Thuis=03, Uit=08 },
                new Score { Thuis=04, Uit=08 },
                new Score { Thuis=05, Uit=08 },
                new Score { Thuis=06, Uit=08 },
                new Score { Thuis=07, Uit=08 },
                new Score { Thuis=08, Uit=08 },
                new Score { Thuis=09, Uit=08 },
                new Score { Thuis=10, Uit=08 },
                new Score { Thuis=00, Uit=09 },
                new Score { Thuis=01, Uit=09 },
                new Score { Thuis=02, Uit=09 },
                new Score { Thuis=03, Uit=09 },
                new Score { Thuis=04, Uit=09 },
                new Score { Thuis=05, Uit=09 },
                new Score { Thuis=06, Uit=09 },
                new Score { Thuis=07, Uit=09 },
                new Score { Thuis=08, Uit=09 },
                new Score { Thuis=09, Uit=09 },
                new Score { Thuis=10, Uit=09 },
                new Score { Thuis=00, Uit=10 },
                new Score { Thuis=01, Uit=10 },
                new Score { Thuis=02, Uit=10 },
                new Score { Thuis=03, Uit=10 },
                new Score { Thuis=04, Uit=10 },
                new Score { Thuis=05, Uit=10 },
                new Score { Thuis=06, Uit=10 },
                new Score { Thuis=07, Uit=10 },
                new Score { Thuis=08, Uit=10 },
                new Score { Thuis=09, Uit=10 },
                new Score { Thuis=10, Uit=10 },
            }.ForEach(s => context.Scores.Add(s));

            context.SaveChanges();

            new List<Wedstrijd>
            {
                new Wedstrijd { ID=1, Datum= DateTime.Parse("14/06/2018 17:00:00"), Team_Thuis_ID=1, Team_Uit_ID=2},
                new Wedstrijd { ID=2, Datum= DateTime.Parse("15/06/2018 14:00:00"), Team_Thuis_ID=3, Team_Uit_ID=4},
            }.ForEach(w => context.Wedstrijden.Add(w));

            context.SaveChanges();
        }
    }
}
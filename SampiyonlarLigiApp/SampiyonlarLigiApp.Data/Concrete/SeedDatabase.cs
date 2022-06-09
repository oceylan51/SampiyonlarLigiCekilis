using Microsoft.EntityFrameworkCore;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new SampiyonlarLigiAppDbContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Group1.Count() == 0)
                {
                    context.Group1.AddRange(group1s);
                }
                if (context.Group2.Count() == 0)
                {
                    context.Group2.AddRange(group2s);
                }
                if (context.Group3.Count() == 0)
                {
                    context.Group3.AddRange(group3s);
                }
                if (context.Group4.Count() == 0)
                {
                    context.Group4.AddRange(group4s);
                }
                if (context.Teams.Count() == 0)
                {
                    context.Teams.AddRange(teams);
                }
                context.SaveChanges();
            }
        }
        private static Teams[] teams =
        {
            new Teams() { TeamName = "Bayern Munich",TeamCountry="Almanya",GroupNumber=1},
            new Teams() { TeamName = "Sevilla",TeamCountry="Ispanya",GroupNumber=1},
            new Teams() { TeamName = "Real Madrid",TeamCountry="Ispanya",GroupNumber=1},
            new Teams() { TeamName = "Liverpool",TeamCountry="Ingiltere",GroupNumber=1},
            new Teams() { TeamName = "Juventus",TeamCountry="Italya",GroupNumber=1},
            new Teams() { TeamName = "PSG",TeamCountry="Fransa",GroupNumber=1},
            new Teams() { TeamName = "Zenit",TeamCountry="Rusya",GroupNumber=1},
            new Teams() { TeamName = "Porto",TeamCountry="Portekiz",GroupNumber=1},
            new Teams() {TeamName="Barcelona",TeamCountry="Ispanya",GroupNumber=2},
            new Teams() {TeamName="Atletico Madrid",TeamCountry="Ispanya",GroupNumber=2},
            new Teams() {TeamName="Manchester City",TeamCountry="Ingiltere",GroupNumber=2},
            new Teams() {TeamName="Manchester United",TeamCountry="Ingiltere",GroupNumber=2},
            new Teams() {TeamName="Borussia Dortmund",TeamCountry="Almanya",GroupNumber=2},
            new Teams() {TeamName="Shaktar Donetsk",TeamCountry="Ukranya",GroupNumber=2},
            new Teams() {TeamName="Chelsea",TeamCountry="Ingiltere",GroupNumber=2},
            new Teams() {TeamName="Ajaz",TeamCountry="Hollanda",GroupNumber=2},
            new Teams(){TeamName="Dynamo Kiev",TeamCountry="Ukranya",GroupNumber=3},
            new Teams(){TeamName="Red Bull Salzburg",TeamCountry="Almanya",GroupNumber=3},
            new Teams(){TeamName="Red Bull Leipzig",TeamCountry="Almanya",GroupNumber=3},
            new Teams(){TeamName="Internazionale",TeamCountry="Italya",GroupNumber=3},
            new Teams(){TeamName="Olympiacos",TeamCountry="Yunanistan",GroupNumber=3},
            new Teams(){TeamName="Lazio",TeamCountry="Italya",GroupNumber=3},
            new Teams(){TeamName="Krasnodar",TeamCountry="Rusya",GroupNumber=3},
            new Teams(){TeamName="Atalanta",TeamCountry="Italya",GroupNumber=3},
            new Teams(){TeamName="Lokomotiv Moskova",TeamCountry="Rusya",GroupNumber=4},
            new Teams(){TeamName="Marseille",TeamCountry="Fransa",GroupNumber=4},
            new Teams(){TeamName="Club Brugge",TeamCountry="Belcika",GroupNumber=4},
            new Teams(){TeamName="Bor. Monchengladbach",TeamCountry="Almanya",GroupNumber=4},
            new Teams(){TeamName="Galatasaray",TeamCountry="Turkiye",GroupNumber=4},
            new Teams(){TeamName="Midtjylland",TeamCountry="Danimarka",GroupNumber=4},
            new Teams(){TeamName="Rennes",TeamCountry="Fransa",GroupNumber=4},
            new Teams(){TeamName="Ferencvaros",TeamCountry="Macaristan",GroupNumber=4},
        };
        private static Group1[] group1s =
        {
            new Group1() { TeamName = "Bayern Munich",TemaCountry="Almanya"},
            new Group1() { TeamName = "Sevilla",TemaCountry="Ispanya"},
            new Group1() { TeamName = "Real Madrid",TemaCountry="Ispanya"},
            new Group1() { TeamName = "Liverpool",TemaCountry="Ingiltere"},
            new Group1() { TeamName = "Juventus",TemaCountry="Italya"},
            new Group1() { TeamName = "PSG",TemaCountry="Fransa"},
            new Group1() { TeamName = "Zenit",TemaCountry="Rusya"},
            new Group1() { TeamName = "Porto",TemaCountry="Portekiz"}
        };
        private static Group2[] group2s =
        {
            new Group2(){TeamName="Barcelona",TemaCountry="Ispanya"},
            new Group2(){TeamName="Atletico Madrid",TemaCountry="Ispanya"},
            new Group2(){TeamName="Manchester City",TemaCountry="Ingiltere"},
            new Group2(){TeamName="Manchester United",TemaCountry="Ingiltere"},
            new Group2(){TeamName="Borussia Dortmund",TemaCountry="Almanya"},
            new Group2(){TeamName="Shaktar Donetsk",TemaCountry="Ukranya"},
            new Group2(){TeamName="Chelsea",TemaCountry="Ingiltere"},
            new Group2(){TeamName="Ajaz",TemaCountry="Hollanda"},
        };
        private static Group3[] group3s =
        {
            new Group3(){TeamName="Dynamo Kiev",TemaCountry="Ukranya"},
            new Group3(){TeamName="Red Bull Salzburg",TemaCountry="Almanya"},
            new Group3(){TeamName="Red Bull Leipzig",TemaCountry="Almanya"},
            new Group3(){TeamName="Internazionale",TemaCountry="Italya"},
            new Group3(){TeamName="Olympiacos",TemaCountry="Yunanistan"},
            new Group3(){TeamName="Lazio",TemaCountry="Italya"},
            new Group3(){TeamName="Krasnodar",TemaCountry="Rusya"},
            new Group3(){TeamName="Atalanta",TemaCountry="Italya"},
        };
        private static Group4[] group4s =
        {
            new Group4(){TeamName="Lokomotiv Moskova",TemaCountry="Rusya"},
            new Group4(){TeamName="Marseille",TemaCountry="Fransa"},
            new Group4(){TeamName="Club Brugge",TemaCountry="Belcika"},
            new Group4(){TeamName="Bor. Monchengladbach",TemaCountry="Almanya"},
            new Group4(){TeamName="Galatasaray",TemaCountry="Turkiye"},
            new Group4(){TeamName="Midtjylland",TemaCountry="Danimarka"},
            new Group4(){TeamName="Rennes",TemaCountry="Fransa"},
            new Group4(){TeamName="Ferencvaros",TemaCountry="Macaristan"},
        };
    }

}

using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class SC_Freiburg
    {
        public static Club GetClub()
        {
            return new Club("SC Freiburg")
            {
                League = "德甲",
                FoundedYear = 1904,
                City = "弗赖堡",

                Stadium = "Europa‑Park Stadion",
                Capacity = 34700,

                Manager = "Christian Streich",
                Reputation = "稳健成长传统型",
                FinanceStatus = "健康",

                Formation = "4231",
                FanExpectation = "稳居欧战资格区",
                Strength = "防守硬朗、主场稳定、青训体系扎实",
                Weakness = "进攻火力稍弱、阵容板凳深度一般",

                KeyPlayers = new List<string>
                {
                    "Vincenzo Grifo",
                    "Michael Gregoritsch",
                    "Ritsu Dōan",
                    "Matthias Ginter",
                    "Mark Flekken"
                },

                Wins = 17,
                Draws = 8,
                Losses = 9,
                GoalsFor = 51,
                GoalsAgainst = 44,
                Position = 5,

                Players = new List<Player>
                {
                    // Example extensions in Player class.
                    // new Player { Name = "Vincenzo Grifo", Position = "Left Winger", Goals = 12, Assists = 5 },
                    // new Player { Name = "Michael Gregoritsch", Position = "Centre-Forward", Goals = 8 },
                    // new Player { Name = "Matthias Ginter", Position = "Centre-Back" },
                    // new Player { Name = "Mark Flekken", Position = "Goalkeeper" },
                }
            };
        }

    }
}

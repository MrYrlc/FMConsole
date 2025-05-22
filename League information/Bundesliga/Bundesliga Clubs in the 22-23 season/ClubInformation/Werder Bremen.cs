using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Werder_Bremen
    {
        public static Club GetClub()
        {
            return new Club("Werder Bremen")
            {
                League = "德甲",
                FoundedYear = 1899,
                City = "不来梅",

                Stadium = "Weserstadion",
                Capacity = 42100,

                Manager = "Ole Werner",
                Reputation = "传统强队，回归稳定",
                FinanceStatus = "健康",

                Formation = "352",
                FanExpectation = "成功保级并争取中游",
                Strength = "防守硬朗、主场不俗、中场控制稳定",
                Weakness = "锋线火力偏弱、客场不稳定",

                KeyPlayers = new List<string>
                {
                    "Niclas Füllkrug",
                    "Marco Friedl",
                    "Marvin Ducksch",
                    "Romano Schmid",
                    "Ilia Gruev"
                },

                Wins = 11,
                Draws = 10,
                Losses = 13,
                GoalsFor = 51,
                GoalsAgainst = 59,
                Position = 14,

                Players = new List<Player>
                {
                    // 推荐在 Player 类中加入字段：Position, Age, Nationality, Goals, Assists, Appearances 等
                    // new Player { Name = "Niclas Füllkrug", Position = "Forward", Goals = 16 },
                    // new Player { Name = "Marco Friedl", Position = "Centre-Back", Nationality = "Austria" },
                    // new Player { Name = "Marvin Ducksch", Position = "Forward", Goals = 12 },
                    // new Player { Name = "Romano Schmid", Position = "Attacking Midfield" },
                    // new Player { Name = "Ilia Gruev", Position = "Defensive Midfield" },
                }
            };
        }

    }
}

using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Union_Berlin
    {
        public static Club GetClub()
        {
            return new Club("Union Berlin")
            {
                League = "德甲",
                FoundedYear = 1906,
                City = "柏林",

                Stadium = "Stadion An der Alten Försterei",
                Capacity = 22412, // 官方数据 :contentReference[oaicite:0]{index=0}

                Manager = "Urs Fischer",
                Reputation = "防守坚固的稳健中层",
                FinanceStatus = "健康",

                Formation = "343",
                FanExpectation = "打进欧冠",
                Strength = "防守强，主场坚如磐石",
                Weakness = "阵容深度稍弱，应对密集赛程吃力",

                KeyPlayers = new List<string>
                {
                    "Sheraldo Becker",
                    "Jordan Siebatcheu",
                    "Janik Haberer",
                    "Rani Khedira",
                    "Frederik Rönnow"
                },

                Wins = 18,
                Draws = 8,
                Losses = 8,
                GoalsFor = 51,
                GoalsAgainst = 38,
                Position = 4,

                Players = new List<Player>
                {
                    // 示例：可以在 Player 类中添加更多字段
                    // new Player { Name = "Sheraldo Becker", Position = "Forward", Goals = 11 },
                    // new Player { Name = "Jordan Siebatcheu", Position = "Forward", Goals = 6 },
                    // new Player { Name = "Janik Haberer", Position = "Midfielder", Goals = 5 },
                    // new Player { Name = "Rani Khedira", Position = "Midfielder", Goals = 3 },
                    // new Player { Name = "Frederik Rönnow", Position = "Goalkeeper", CleanSheets = 11 }
                }
            };
        }

    }
}

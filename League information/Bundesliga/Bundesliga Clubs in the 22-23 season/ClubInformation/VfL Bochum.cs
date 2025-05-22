using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class VfL_Bochum
    {
        public static Club GetClub()
        {
            return new Club("VfL Bochum")
            {
                League = "德甲",
                FoundedYear = 1848,
                City = "博鸿",

                Stadium = "Vonovia Ruhrstadion",
                Capacity = 27599,

                Manager = "托马斯·雷斯（至2022‑09‑12）、托马斯·莱茨（自2022‑09‑22）",
                Reputation = "德甲坚韧保级队",
                FinanceStatus = "稳健",

                Formation = "4231",
                FanExpectation = "成功保级",
                Strength = "主场表现稳定，战术纪律强",
                Weakness = "客场表现低迷，防守存在漏洞",

                KeyPlayers = new List<string>
                {
                    "菲利普·霍夫曼",
                    "安东尼·洛西拉",
                    "菲利普·勒斯特格",
                    "马努埃尔·里曼",
                    "丹尼·德·维特"
                },

                Wins = 10,
                Draws = 5,
                Losses = 19,
                GoalsFor = 40,
                GoalsAgainst = 72,
                Position = 14,

                Players = new List<Player>
                {
                    // 在 Player 类中建议加入 Position, Age, Nationality, Goals, Assists 等字段
                    // new Player { Name = "Philipp Hofmann", Position = "Forward", Goals = 8, Appearances = 34 },
                    // new Player { Name = "Manuel Riemann", Position = "Goalkeeper" },
                    // new Player { Name = "Anthony Losilla", Position = "Defensive Midfielder", Assists = 3 },
                }
            };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMShell.Models;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    public static class Bayern_Munich
    {
        public static Club GetClub()
        {
            return new Club("拜仁慕尼黑")
            {
                League = "德甲",
                FoundedYear = 1900,
                City = "慕尼黑",

                Stadium = "安联球场",
                Capacity = 75000,

                Manager = "UserName",
                Reputation = "世界级",
                FinanceStatus = "富裕",

                Formation = "433",
                FanExpectation = "赢得联赛并打进欧冠四强",
                Strength = "攻击火力强、阵容深度好",
                Weakness = "防守不稳定、教练更换期",

                KeyPlayers = new List<string>
                {
                    "约书亚·基米希",
                    "贾马尔·穆西亚拉",
                    "托马斯·穆勒",
                    "金斯利·科曼",
                    "勒罗伊·萨内"
                },

                Wins = 21,
                Draws = 8,
                Losses = 5,
                GoalsFor = 92,
                GoalsAgainst = 38,
                Position = 1,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你自行定义 Player 类
                    // new Player { Name = "约书亚·基米希", Position = "中场" },
                    // new Player { Name = "曼努埃尔·诺伊尔", Position = "门将" },
                }
            };
        }
    }
}

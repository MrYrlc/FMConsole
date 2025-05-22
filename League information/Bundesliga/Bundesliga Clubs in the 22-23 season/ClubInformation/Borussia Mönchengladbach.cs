using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Borussia_Mönchengladbach
    {
        public static Club GetClub()
        {
            return new Club("门兴格拉德巴赫")
            {
                League = "德甲",
                FoundedYear = 1900,
                City = "门兴格拉德巴赫",

                Stadium = "普鲁士公园球场",
                Capacity = 54022,

                Manager = "丹尼尔·法尔克",
                Reputation = "德甲传统强队",
                FinanceStatus = "稳定",

                Formation = "4231",
                FanExpectation = "冲击欧战资格",
                Strength = "边路进攻强、部分球员技术细腻",
                Weakness = "防守线不稳、阵容深度不足",

                KeyPlayers = new List<string>
                {
                    "马库斯·图拉姆",
                    "乔纳斯·霍夫曼",
                    "阿拉萨内·普莱亚",
                    "克里斯托夫·克拉默",
                    "尼科·埃尔维迪"
                },

                Wins = 10,
                Draws = 10,
                Losses = 14,
                GoalsFor = 52,
                GoalsAgainst = 55,
                Position = 10,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "马库斯·图拉姆", Position = "前锋" },
                    // new Player { Name = "乔纳斯·霍夫曼", Position = "右边锋" },
                    // new Player { Name = "尼科·埃尔维迪", Position = "中后卫" },
                }
            };
        }

    }
}

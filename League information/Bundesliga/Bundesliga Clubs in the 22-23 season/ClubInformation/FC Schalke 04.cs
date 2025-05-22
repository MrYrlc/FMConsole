using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class FC_Schalke_04
    {
        public static Club GetClub()
        {
            return new Club("沙尔克04")
            {
                League = "德甲",
                FoundedYear = 1904,
                City = "盖尔森基兴",

                Stadium = "Veltins‑Arena",
                Capacity = 62271,

                Manager = "弗兰克·克拉默（至2022‑10‑19）、托马斯·赖斯（自2022‑10‑27）",
                Reputation = "曾经的德国豪门",
                FinanceStatus = "财务吃紧",

                Formation = "433",
                FanExpectation = "保级",
                Strength = "大球场气氛震撼、主场防守一度稳固",
                Weakness = "赛季开局最差、阵容磨合不足",

                KeyPlayers = new List<string>
                {
                    "马里乌斯·比尔特（11球）",
                    "蒂莫·施洛特贝克",
                    "尹·默多伊亚",
                    "马雅·吉世达",
                    "托马斯·奥维扬"
                },

                Wins = 9,
                Draws = 12,
                Losses = 13,
                GoalsFor = 31,
                GoalsAgainst = 71,
                Position = 17,

                Players = new List<Player>
                {
                    // 你可以扩展 Player 类，加入更多信息
                    // new Player { Name = "马里乌斯·比尔特", Position = "前锋" },
                    // new Player { Name = "蒂莫·施洛特贝克", Position = "中后卫" },
                    // new Player { Name = "马雅·吉世达", Position = "中后卫" },
                }
            };
        }

    }
}

using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class VfB_Stuttgart
    {
        public static Club GetClub()
        {
            return new Club("VfB Stuttgart")
            {
                League = "德甲",
                FoundedYear = 1893,
                City = "斯图加特",

                Stadium = "MHPArena（原 Mercedes‑Benz Arena）",
                Capacity = 47500, // 重建期间容量:contentReference[oaicite:0]{index=0}

                Manager = "佩莱格里诺·马塔拉佐（至2022‑10‑10）、迈克尔·威默（临时执教）、布鲁诺·拉巴迪亚（2022‑12‑05 至2023‑04‑03）、塞巴斯蒂安·霍内斯（自2023‑04‑03）",
                Reputation = "德国传统强队",
                FinanceStatus = "健康稳健（有保时捷/奔驰支持）",

                Formation = "4231",
                FanExpectation = "成功保级，争取上游",
                Strength = "锋线多点发力、防守韧性、换帅后战术调整迅速",
                Weakness = "季初表现低迷、主场重建影响氛围、换帅造成不稳定",

                KeyPlayers = new List<string>
                {
                    "赛尔胡·吉拉西（Serhou Guirassy）",
                    "德尼兹·安达夫（Deniz Undav）",
                    "克里斯·弗吕里希（Chris Führich）",
                    "瓦塔鲁·恩多（Wataru Endō）",
                    "斯洛莫·库利巴利（Tanguy Coulibaly）"
                },

                Wins = 7,
                Draws = 12,
                Losses = 15,
                GoalsFor = 38,   // Bundesliga 总进球数（估算）
                GoalsAgainst = 60, // 粗略估算
                Position = 16,

                Players = new List<Player>
                {
                    // 示例：建议你扩展 Player 类字段，如 Position, Goals, Assists, Appearances 等
                    // new Player { Name = "Serhou Guirassy", Position = "Forward", Goals = 11 },
                    // new Player { Name = "Deniz Undav", Position = "Forward", Goals = 19 },
                    // new Player { Name = "Chris Führich", Position = "Midfielder", Goals = 4 },
                    // new Player { Name = "Wataru Endo", Position = "Midfielder", Goals = 3 },
                    // new Player { Name = "Konstantinos Mavropanos", Position = "Defender", Goals = 2 },
                }
            };
        }

    }
}

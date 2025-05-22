using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class FC_Augsburg
    {
        public static Club GetClub()
        {
            return new Club("奥格斯堡")
            {
                League = "德甲",
                FoundedYear = 1907,
                City = "奥格斯堡",

                Stadium = "WWK竞技场",
                Capacity = 30660,

                Manager = "恩里科·马森",
                Reputation = "保级常客",
                FinanceStatus = "一般",

                Formation = "442",
                FanExpectation = "成功保级",
                Strength = "拼抢积极、边路突破能力尚可",
                Weakness = "整体技术水平一般、控球能力弱",

                KeyPlayers = new List<string>
                {
                    "厄尔梅丁·德米洛维奇",
                    "阿尔内·迈尔",
                    "杰弗里·豪韦勒乌",
                    "卡洛斯·格鲁埃索",
                    "拉法尔·吉基维茨"
                },

                Wins = 9,
                Draws = 7,
                Losses = 18,
                GoalsFor = 42,
                GoalsAgainst = 63,
                Position = 15,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "厄尔梅丁·德米洛维奇", Position = "前锋" },
                    // new Player { Name = "阿尔内·迈尔", Position = "中场" },
                    // new Player { Name = "拉法尔·吉基维茨", Position = "门将" },
                }
            };
        }

    }
}

using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Borussia_Dortmund
    {
        public static Club GetClub()
        {
            return new Club("多特蒙德")
            {
                League = "德甲",
                FoundedYear = 1909,
                City = "多特蒙德",

                Stadium = "西格纳·伊杜纳公园",
                Capacity = 81365,

                Manager = "埃丁·特尔齐奇",
                Reputation = "欧洲豪门",
                FinanceStatus = "健康",

                Formation = "4231",
                FanExpectation = "争冠",
                Strength = "青年才俊多、主场气势强、进攻多样",
                Weakness = "关键战掉链子、防守容易被打穿",

                KeyPlayers = new List<string>
                {
                    "裘德·贝林厄姆",
                    "马尔科·罗伊斯",
                    "朱利安·布兰特",
                    "尼科·施洛特贝克",
                    "格雷罗"
                },

                Wins = 22,
                Draws = 5,
                Losses = 7,
                GoalsFor = 83,
                GoalsAgainst = 44,
                Position = 2,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "裘德·贝林厄姆", Position = "中场" },
                    // new Player { Name = "马尔科·罗伊斯", Position = "前腰" },
                    // new Player { Name = "格雷罗", Position = "左后卫" },
                }
            };
        }

    }
}

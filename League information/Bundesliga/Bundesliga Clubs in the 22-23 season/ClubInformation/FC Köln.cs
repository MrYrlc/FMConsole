using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class FC_Köln
    {
        public static Club GetClub()
        {
            return new Club("科隆")
            {
                League = "德甲",
                FoundedYear = 1948,
                City = "科隆",

                Stadium = "莱茵能源体育场",
                Capacity = 50000,

                Manager = "施特芬·鲍姆加特",
                Reputation = "中游劲旅",
                FinanceStatus = "正常",

                Formation = "4231",
                FanExpectation = "保级无忧，争取欧战资格",
                Strength = "团队作战意识强、跑动积极",
                Weakness = "锋线效率低、防线容易被冲击",

                KeyPlayers = new List<string>
                {
                    "乔纳斯·赫克托",
                    "弗洛里安·凯因茨",
                    "戴维·塞尔克",
                    "埃利亚斯·斯希里",
                    "蒂莫·许伯斯"
                },

                Wins = 10,
                Draws = 12,
                Losses = 12,
                GoalsFor = 49,
                GoalsAgainst = 54,
                Position = 11,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "乔纳斯·赫克托", Position = "左后卫" },
                    // new Player { Name = "弗洛里安·凯因茨", Position = "边锋" },
                    // new Player { Name = "埃利亚斯·斯希里", Position = "后腰" },
                }
            };
        }

    }
}

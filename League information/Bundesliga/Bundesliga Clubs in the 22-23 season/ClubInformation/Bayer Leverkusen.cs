using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Bayer_Leverkusen
    {
        public static Club GetClub()
        {
            return new Club("勒沃库森")
            {
                League = "德甲",
                FoundedYear = 1904,
                City = "勒沃库森",

                Stadium = "拜耳竞技场",
                Capacity = 30210,

                Manager = "哈维·阿隆索",
                Reputation = "欧洲知名",
                FinanceStatus = "稳定",

                Formation = "343",
                FanExpectation = "争夺欧战资格",
                Strength = "年轻有活力、边路快速反击犀利",
                Weakness = "防守端容易出错、经验不足",

                KeyPlayers = new List<string>
                {
                    "穆萨·迪亚比",
                    "弗洛里安·维尔茨",
                    "杰雷米·弗林蓬",
                    "卢卡斯·赫拉德茨基",
                    "埃克塔尔·塔普索巴"
                },

                Wins = 14,
                Draws = 8,
                Losses = 12,
                GoalsFor = 57,
                GoalsAgainst = 48,
                Position = 6,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "穆萨·迪亚比", Position = "边锋" },
                    // new Player { Name = "弗洛里安·维尔茨", Position = "前腰" },
                    // new Player { Name = "卢卡斯·赫拉德茨基", Position = "门将" },
                }
            };
        }

    }
}

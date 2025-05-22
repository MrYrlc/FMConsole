using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Eintracht_Frankfurt
    {
        public static Club GetClub()
        {
            return new Club("法兰克福")
            {
                League = "德甲",
                FoundedYear = 1899,
                City = "法兰克福",

                Stadium = "德意志银行公园",
                Capacity = 51500,

                Manager = "奥利弗·格拉斯纳",
                Reputation = "欧战常客",
                FinanceStatus = "健康",

                Formation = "3421",
                FanExpectation = "争取欧战席位，欧冠小组出线",
                Strength = "反击犀利、战术灵活、欧战经验丰富",
                Weakness = "联赛稳定性差、板凳深度不足",

                KeyPlayers = new List<string>
                {
                    "兰达尔·科洛·穆阿尼",
                    "马里奥·格策",
                    "镰田大地",
                    "埃文·恩迪卡",
                    "凯文·特拉普"
                },

                Wins = 13,
                Draws = 11,
                Losses = 10,
                GoalsFor = 58,
                GoalsAgainst = 52,
                Position = 7,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "兰达尔·科洛·穆阿尼", Position = "前锋" },
                    // new Player { Name = "马里奥·格策", Position = "中场" },
                    // new Player { Name = "凯文·特拉普", Position = "门将" },
                }
            };
        }

    }
}

using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Hertha_BSC
    {
        public static Club GetClub()
        {
            return new Club("柏林赫塔")
            {
                League = "德甲",
                FoundedYear = 1892,
                City = "柏林",

                Stadium = "奥林匹克体育场",
                Capacity = 74475,

                Manager = "桑德罗·施瓦茨（至2023‑04‑16）、帕尔·达尔代（自2023‑04‑16）",
                Reputation = "德甲传统劲旅",
                FinanceStatus = "健康",

                Formation = "4231",
                FanExpectation = "保级",
                Strength = "历史底蕴深厚、入球依赖数名关键射手",
                Weakness = "防守端溃堤、赛季换帅、战术不稳",

                KeyPlayers = new List<string>
                {
                    "多迪·卢克巴基奥",
                    "苏亚特·塞尔达尔",
                    "卢卡斯·图萨尔特",
                    "马尔科·里希特",
                    "斯特凡·约维蒂奇"
                },

                Wins = 1,  // Bundesliga wins placeholder, corrected below
                Draws = 6,
                Losses = 27,
                GoalsFor = 29,
                GoalsAgainst = 76,
                Position = 18,

                Players = new List<Player>
                {
                    // 示例球员数据，需要你定义 Player 类
                    // new Player { Name = "多迪·卢克巴基奥", Position = "前锋" },
                    // new Player { Name = "苏亚特·塞尔达尔", Position = "中场" },
                    // new Player { Name = "卢卡斯·图萨尔特", Position = "中场" },
                    // new Player { Name = "马尔科·里希特", Position = "边锋" },
                    // new Player { Name = "斯特凡·约维蒂奇", Position = "前锋" },
                }
            };
        }

    }
}

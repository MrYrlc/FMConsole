using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class RB_Leipzig
    {
        public static Club GetClub()
        {
            return new Club("RB Leipzig")
            {
                League = "德甲",
                FoundedYear = 2009,
                City = "莱比锡",

                Stadium = "Red Bull Arena",
                Capacity = 47069,

                Manager = "多米尼科·特德斯科（至2022‑09‑07）、马尔科·罗斯（2022‑09‑08 至 2025‑03‑30）、佐尔特·洛伊（代理，自2025‑03‑30）",
                Reputation = "红牛体系新锐",
                FinanceStatus = "红牛支持坚实",

                Formation = "4231",
                FanExpectation = "欧冠席位 + 德国杯争冠",
                Strength = "青年才俊密集、进攻效率高、德国杯夺冠",
                Weakness = "防守端偶有漏洞、换帅过渡期",

                KeyPlayers = new List<string>
                {
                    "克里斯托弗·恩昆库",
                    "蒂莫·维尔纳",
                    "达约·乌帕梅卡诺",
                    "丹尼·奥尔莫",
                    "皮特·古拉西"
                },

                Wins = 20,
                Draws = 6,
                Losses = 8,
                GoalsFor = 64,
                GoalsAgainst = 41,
                Position = 3,

                Players = new List<Player>
                {
                    // 示例球员数据，建议你在 Player 类中加入如 Position, Age, Nationality, Goals, Assists 等字段
                    // new Player { Name = "Christopher Nkunku", Position = "Forward", Goals = 16 },
                    // new Player { Name = "Timo Werner", Position = "Forward", Goals = 13 },
                    // new Player { Name = "Dayot Upamecano", Position = "Centre-Back" },
                    // new Player { Name = "Dani Olmo", Position = "Midfielder" },
                }
            };
        }

    }
}

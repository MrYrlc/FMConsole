using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class TSG_Hoffenheim
    {
        public static Club GetClub()
        {
            return new Club("TSG 1899 Hoffenheim")
            {
                League = "德甲",
                FoundedYear = 1899,
                City = "辛斯海姆",

                Stadium = "Rhein-Neckar-Arena",
                Capacity = 30164,

                Manager = "安德烈·布赖滕赖特（至2023‑02‑06）、佩莱格里诺·马塔拉佐（自2023‑02‑08）",
                Reputation = "稳定中游",
                FinanceStatus = "健康",

                Formation = "4231",
                FanExpectation = "稳固中游、德甲保级无忧",
                Strength = "战术灵活、进攻端有 Kramarić 支撑",
                Weakness = "防守仍有漏洞、换帅过渡期影响",

                KeyPlayers = new List<string>
                {
                    "安德烈·克拉玛里奇",
                    "穆纳斯·达布尔",
                    "克里斯托夫·鲍姆加特纳",
                    "安热利尼奥",
                    "奥赞·卡巴克"
                },

                Wins = 10,
                Draws = 6,
                Losses = 18,
                GoalsFor = 48,
                GoalsAgainst = 57,
                Position = 12,

                Players = new List<Player>
                {
                    // 示例，建议扩展 Player 类字段：
                    // new Player { Name = "Andrej Kramarić", Position = "Forward", Goals = 12 },
                    // new Player { Name = "Christoph Baumgartner", Position = "Midfielder", Goals = 5 },
                    // new Player { Name = "Oliver Baumann", Position = "Goalkeeper" },
                }
            };
        }

    }
}

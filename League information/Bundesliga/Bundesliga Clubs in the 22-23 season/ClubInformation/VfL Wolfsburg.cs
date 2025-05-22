using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class VfL_Wolfsburg
    {
        public static Club GetClub()
        {
            return new Club("VfL Wolfsburg")
            {
                League = "德甲",
                FoundedYear = 1945,
                City = "沃尔夫斯堡",

                Stadium = "Volkswagen Arena",
                Capacity = 30000, // 包括 22,000 座席 + 8,000 可调站席 :contentReference[oaicite:0]{index=0}

                Manager = "尼科·科瓦奇（全季执教）",
                Reputation = "德国传统俱乐部，背靠大众",
                FinanceStatus = "稳定（大众集团支持）",

                Formation = "4231",
                FanExpectation = "冲击欧战资格",
                Strength = "中场组织稳健，换帅前保级有余",
                Weakness = "攻击效率偏低，防守不够坚固",

                KeyPlayers = new List<string>
                {
                    "扬尼克·格哈特（Yannick Gerhardt）",
                    "欧马尔·马尔穆什（Omar Marmoush）",
                    "乔纳斯·温德（Jonas Wind）",
                    "里德尔·巴库（Ridle Baku）",
                    "马蒂亚斯·斯旺伯格（Mattias Svanberg）"
                },

                Wins = 13,
                Draws = 10,
                Losses = 11,
                GoalsFor = 49,
                GoalsAgainst = 41,
                Position = 8,

                Players = new List<Player>
                {
                    // 可以扩展 Player 类，增加更多字段如 Age, Nationality, Goals, Assists 等
                    // new Player { Name = "Yannick Gerhardt", Position = "Midfielder", Goals = 6 },
                    // new Player { Name = "Omar Marmoush", Position = "Forward", Goals = 5 },
                    // new Player { Name = "Ridle Baku", Position = "Midfielder/Full‑Back", Assists = 8 },
                }
            };
        }

    }
}

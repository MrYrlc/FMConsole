using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation
{
    internal class Mainz
    {
        public static Club GetClub()
        {
            return new Club("美因茨 05")
            {
                League = "德甲",
                FoundedYear = 1905,
                City = "美因茨",

                Stadium = "Mewa Arena",
                Capacity = 33305, // 美因茨官方数据 :contentReference[oaicite:0]{index=0}

                Manager = "Bo Svensson",
                Reputation = "中上游稳定",
                FinanceStatus = "健康",

                Formation = "343",
                FanExpectation = "中游赛季，进步优先",
                Strength = "防守坚韧、主场表现可靠",
                Weakness = "攻击端火力一般，阵容深度有限",

                KeyPlayers = new List<string>
                {
                    "马库斯·因格瓦特森",
                    "乔纳森·布尔卡特",
                    "保罗·内贝尔",
                    "卢卡斯·温德尔",
                    "罗宾·蒸纳"
                },

                Wins = 12,
                Draws = 10,
                Losses = 12,
                GoalsFor = 54,
                GoalsAgainst = 55,
                Position = 9,

                Players = new List<Player>
                {
                    // 示例：根据 FBref / wiki 数据可补全更多字段
                    // new Player { Name = "Marcus Ingvartsen", Position = "前锋", Goals = 10 },
                    // new Player { Name = "Jonathan Burkardt", Position = "前锋", Goals = 1 },
                }
            };
        }

    }
}

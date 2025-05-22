using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.Function.Show
{
    public static class ShowClubInformation
    {
        public static void ShowClubInf(Club club)
        {
            Console.WriteLine("========== 俱乐部信息 ==========");
            Console.WriteLine($"名称：{club.Name}");
            Console.WriteLine($"联赛：{club.League}");
            Console.WriteLine($"成立年份：{club.FoundedYear}");
            Console.WriteLine($"所在城市：{club.City}");
            Console.WriteLine($"主场：{club.Stadium}");
            Console.WriteLine($"容量：{club.Capacity}");
            Console.WriteLine($"主教练：{club.Manager}");
            Console.WriteLine($"声望：{club.Reputation}");
            Console.WriteLine($"财政状况：{club.FinanceStatus}");
            Console.WriteLine($"阵型：{club.Formation}");
            Console.WriteLine($"球迷期望：{club.FanExpectation}");
            Console.WriteLine($"优势：{club.Strength}");
            Console.WriteLine($"劣势：{club.Weakness}");
            Console.WriteLine($"胜场：{club.Wins} 平局：{club.Draws} 负场：{club.Losses}");
            Console.WriteLine($"进球数：{club.GoalsFor} 失球数：{club.GoalsAgainst}");
            Console.WriteLine($"当前排名：第 {club.Position} 名");

            Console.WriteLine("\n关键球员：");
            foreach (var player in club.KeyPlayers)
            {
                Console.WriteLine($" - {player}");
            }
        }
    }
}

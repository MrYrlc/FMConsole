using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.Models
{
    public class Club
    {
        public string Name { get; set; }
        public List<Player> Player { get; set; } = new List<Player>();

        // 比赛记录
        public int MatchesPlayed { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int GoalsFor { get; set; } = 0;
        public int GoalsAgainst { get; set; } = 0;

        public int Points => Wins * 3 + Draws;
        public int GoalDifference => GoalsFor - GoalsAgainst;

        public Club(string name)
        {
            Name = name;
        }

        // 自动挑出11名体能良好、没受伤的球员（临时首发）
        public List<Player> GetStartingLineup()
        {
            return Player
                .Where(p => !p.IsInjured && p.Fitness >= 60)
                .OrderByDescending(p => p.Rating)
                .Take(11)
                .ToList();
        }

        // 打印球队概况（积分榜用）
        public override string ToString()
        {
            return $"{Name} - {Points}分 | {Wins}胜 {Draws}平 {Losses}负 | 进{GoalsFor} / 失{GoalsAgainst} | 净胜球 {GoalDifference}";
        }
    }
}

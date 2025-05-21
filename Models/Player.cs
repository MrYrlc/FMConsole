using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.Models
{
    //定义球员位置
    public enum Position   
    {
        GK,
        CB,
        LB,
        RB,
        CM,
        CDM,
        CAM,
        LW,
        RW,
        ST,
        CF,
        RWB,
        LWB
    }

    //球员属性
    public class Player
    {
        //基础信息
        public string Name { get; set; }
        public int Age { get; set; }
        public Position Pos { get; set; }
        public string Club { get; set; }
        public int Rating { get; set; } // 当前能力值
        public int Potential { get; set; } // 潜力上限

        // 赛季表现统计
        public int Goals { get; set; } = 0;
        public int Assists { get; set; } = 0;
        public int Appearances { get; set; } = 0;

        // 状态管理
        public bool IsInjured { get; set; } = false;
        public int InjuryRounds { get; set; } = 0; // 伤停轮数
        public int Fitness { get; set; } = 100; // 体能值

        public Player(string name, int age, Position pos, string club , int rating, int potential)
        {
            Name = name;
            Age = age;
            Pos = pos;
            Club = club;
            Rating = rating;
            Potential = potential;
        }
        public void RecoverFromInjury()
        {
            if (IsInjured)
            {
                InjuryRounds--;
                if (InjuryRounds <= 0)
                {
                    IsInjured = false;
                    InjuryRounds = 0;
                }
            }
        }
        public static string PadString(string input, int totalWidth)
        {
            int realWidth = 0;
            foreach (char c in input)
            {
                // 中文字符算2格，其他算1格
                realWidth += (c >= 0x4e00 && c <= 0x9fbb) ? 2 : 1;
            }

            int padding = Math.Max(0, totalWidth - realWidth);
            return input + new string(' ', padding);
        }
        public override string ToString()
        {
            return string.Format(
                "{0} | {1,-4} | {2} | {3,2} 能力 | {4,2} 进球 {5,2} 助攻 | {6}",
                PadString(Name, 28),
                Pos,
                PadString(Club, 14),
                Rating,
                Goals,
                Assists,
                IsInjured ? $"受伤({InjuryRounds}轮)" : "健康"
            );
        }


    }
}

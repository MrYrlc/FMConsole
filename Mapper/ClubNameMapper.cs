using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.Mapper
{
    internal class ClubNameMapper
    {
        public static readonly Dictionary<string, string> ChineseToEnglishClubName = new Dictionary<string, string>()
        {
            { "拜仁慕尼黑", "Bayern Munich" },
            { "多特蒙德", "Borussia Dortmund" },
            { "RB莱比锡", "RB Leipzig" },
            { "柏林联合", "Union Berlin" },
            { "弗赖堡", "SC Freiburg" },
            { "勒沃库森", "Bayer Leverkusen" },
            { "美因茨", "Mainz" },
            { "沃尔夫斯堡", "VfL Wolfsburg" },
            { "门兴格拉德巴赫", "Borussia Mönchengladbach" },
            { "法兰克福", "Eintracht Frankfurt" },
            { "霍芬海姆", "TSG Hoffenheim" },
            { "不来梅", "Werder Bremen" },
            { "科隆", "FC Köln" },
            { "奥格斯堡", "FC Augsburg" },
            { "斯图加特", "VfB Stuttgart" },
            { "波鸿", "VfL Bochum" },
            { "柏林赫塔", "Hertha BSC" },
            { "沙尔克04", "Schalke 04" }
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.FirstTeamPlayers;
using FMShell.Models;

namespace FMShell.Mapper
{
    //根据球队英文名来获取对应的（Bayern_Munich.BayernMunich22_23FirstTeamPlayers）这种格式的代码
    internal class FirstTeamPlayerMapper
    {
        public static readonly Dictionary<string, List<Player>> ClubToPlayers = new Dictionary<string, List<Player>>()
        {
            { "Bayer Leverkusen", Bayer_Leverkusen.Bayer_Leverkusen22_23FirstTeamPlayers },
            { "Bayern Munich", Bayern_Munich.Bayern_Munich22_23FirstTeamPlayers },
            { "Borussia Dortmund", Borussia_Dortmund.Borussia_Dortmund22_23FirstTeamPlayers },
            { "Borussia Mönchengladbach", Borussia_Mönchengladbach.Borussia_Mönchengladbach22_23FirstTeamPlayers },
            { "Eintracht Frankfurt", Eintracht_Frankfurt.Eintracht_Frankfurt22_23FirstTeamPlayers },
            { "FC Augsburg", FC_Augsburg.FC_Augsburg22_23FirstTeamPlayers },
            { "FC Köln", FC_Köln.FC_Köln22_23FirstTeamPlayers },
            { "FC Schalke 04", FC_Schalke_04.FC_Schalke_0422_23FirstTeamPlayers },
            { "Hertha BSC", Hertha_BSC.Hertha_BSC22_23FirstTeamPlayers },
            { "Mainz", Mainz.Mainz22_23FirstTeamPlayers },
            { "RB Leipzig", RB_Leipzig.RB_Leipzig22_23FirstTeamPlayers },
            { "SC Freiburg", SC_Freiburg.SC_Freiburg22_23FirstTeamPlayers },
            { "TSG Hoffenheim", TSG_Hoffenheim.TSG_Hoffenheim22_23FirstTeamPlayers },
            { "Union Berlin", Union_Berlin.Union_Berlin22_23FirstTeamPlayers },
            { "VfB Stuttgart", VfB_Stuttgart.VfB_Stuttgart22_23FirstTeamPlayers },
            { "VfL Bochum", VfL_Bochum.VfL_Bochum22_23FirstTeamPlayers },
            { "VfL Wolfsburg", VfL_Wolfsburg.VfL_Wolfsburg22_23FirstTeamPlayers },
            { "Werder Bremen", Werder_Bremen.Werder_Bremen22_23FirstTeamPlayers }
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.FirstTeamPlayers;
using FMShell.Models;

namespace FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season
{
    //根据球队英文名来获取对应的（Bayern_Munich.BayernMunich22_23FirstTeamPlayers）这种格式的代码
    internal class FirstTeamPlayerMapper
    {
        public static readonly Dictionary<string, List<Player>> ClubToPlayers = new Dictionary<string, List<Player>>()
        {
            { "Bayer Leverkusen", Bayer_Leverkusen.BayerLeverkusen22_23FirstTeamPlayers },
            { "Bayern Munich", Bayern_Munich.BayernMunich22_23FirstTeamPlayers },
            { "Borussia Dortmund", Borussia_Dortmund.BorussiaDortmund22_23FirstTeamPlayers },
            { "Borussia Mönchengladbach", Borussia_Mönchengladbach.BorussiaMönchengladbach22_23FirstTeamPlayers },
            { "Eintracht Frankfurt", Eintracht_Frankfurt.EintrachtFrankfurt22_23FirstTeamPlayers },
            { "FC Augsburg", FC_Augsburg.FCAugsburg22_23FirstTeamPlayers },
            { "FC Köln", FC_Köln.FCKöln22_23FirstTeamPlayers },
            { "FC Schalke 04", FC_Schalke_04.FCSchalke04_22_23FirstTeamPlayers },
            { "Hertha BSC", Hertha_BSC.HerthaBSC22_23FirstTeamPlayers },
            { "Mainz", Mainz.Mainz22_23FirstTeamPlayers },
            { "RB Leipzig", RB_Leipzig.RBLeipzig22_23FirstTeamPlayers },
            { "SC Freiburg", SC_Freiburg.SCFreiburg22_23FirstTeamPlayers },
            { "TSG Hoffenheim", TSG_Hoffenheim.TSGHoffenheim22_23FirstTeamPlayers },
            { "Union Berlin", Union_Berlin.UnionBerlin22_23FirstTeamPlayers },
            { "VfB Stuttgart", VfB_Stuttgart.VfBStuttgart22_23FirstTeamPlayers },
            { "VfL Bochum", VfL_Bochum.VfLBochum22_23FirstTeamPlayers },
            { "VfL Wolfsburg", VfL_Wolfsburg.VfLWolfsburg22_23FirstTeamPlayers },
            { "Werder Bremen", Werder_Bremen.WerderBremen22_23FirstTeamPlayers }
        };
    }
}

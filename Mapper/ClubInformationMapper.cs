using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation;
using FMShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMShell.Mapper
{
    public class ClubInformationMapper
    {
        public static readonly Dictionary<string, Club> ClubToClubInformation = new Dictionary<string, Club>()
        {
            { "Bayer Leverkusen", Bayer_Leverkusen.GetClub()},
            { "Bayern Munich", Bayern_Munich.GetClub()},
            { "Borussia Dortmund", Borussia_Dortmund.GetClub()},
            { "Borussia Mönchengladbach", Borussia_Mönchengladbach.GetClub()},
            { "Eintracht Frankfurt", Eintracht_Frankfurt.GetClub()},
            { "FC Augsburg", FC_Augsburg.GetClub()},
            { "FC Köln", FC_Köln.GetClub()},
            { "FC Schalke 04", FC_Schalke_04.GetClub()},
            { "Hertha BSC", Hertha_BSC.GetClub()},
            { "Mainz", Mainz.GetClub()},
            { "RB Leipzig", RB_Leipzig.GetClub()},
            { "SC Freiburg", SC_Freiburg.GetClub()},
            { "TSG Hoffenheim", TSG_Hoffenheim.GetClub()},
            { "Union Berlin", Union_Berlin.GetClub()},
            { "VfB Stuttgart", VfB_Stuttgart.GetClub()},
            { "VfL Bochum", VfL_Bochum.GetClub()},
            { "VfL Wolfsburg", VfL_Wolfsburg.GetClub()},
            { "Werder Bremen", Werder_Bremen.GetClub()}
        };
    }
}

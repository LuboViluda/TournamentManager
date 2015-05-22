using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// trieda, ktora si uklada informacie o zapase, napriklad tymy ktore proti sebe hrali, 
/// pocet golov tymov a jednotlivych hracov, taktiez ci bol zapas uz odohrany
/// </summary>

namespace TournamentManager
{
    public class Match
    {
        public Team team1;
        public Team team2;
        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }
        public int Team1Player1Goals { get; set; }
        public int Team1Player2Goals { get; set; }
        public int Team2Player1Goals { get; set; }
        public int Team2Player2Goals { get; set; }
        public bool Played { get; set; }

        private Match() { }
        public Match(Team parTeam1, Team parTeam2)
        {
            team1 = parTeam1;
            team2 = parTeam2;
            Team1Goals = 0;
            Team2Goals = 0;
            Team1Player1Goals = 0;
            Team1Player2Goals = 0;
            Team2Player1Goals = 0;
            Team2Player2Goals = 0;
            Played = false;
        }
       
    }
}

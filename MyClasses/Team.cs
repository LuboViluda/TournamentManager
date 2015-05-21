using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    // wpf
    // ioc structure map, ninject
    public class Team  : IComparable<Team>
    {
        public List<Player> Players;
        public string TeamName { get; set; }
        public int Group { get; set; }
        public int Basket { get; set; }
        public int GA { get; set; }     // goals have been scored against this team
        public int GF { get; set; }     // goals have been scored by this team
        public int GP { get; set; }     // game played
        public int Diff { get; set; }   // GF - GA 
        public int Points { get; set; }
        public Team(string parTeamName, Player player1, Player player2, int basket)
        {
            TeamName = parTeamName;
            Players = new List<Player>();
            Players.Add(player1);
            Players.Add(player2);
            Basket = basket;
            Group = 0;      // 0 -> hasn't group now
            GA = GF = GP = Diff = Points = 0;
        }
        public int CompareTo(Team other)
        {   // first point, difference in score, goal in score
            if (this.Points > other.Points)
            {
                return -1;
            }
            else
            {
                if (this.Points < other.Points)
                {
                    return 1;
                }
            }
            if (this.Diff > other.Diff)
            {
                return -1;
            }
            else
            {
                if (this.Diff < other.Diff)
                {
                    return 1;
                }
            }
            if (this.GF > other.GF)
            {
                return -1;
            }
            else
            {
                if (this.GF < other.GF)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}

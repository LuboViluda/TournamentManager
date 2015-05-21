using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    public class Player 
    {
        public String Name { get; set; }       
        public int GFbyPlayer { get; set; }
        public int GAbyPlayer { get; set; }
        public int GP { get; set; }
        public Player(string parName)
        {
            Name = parName;
            GFbyPlayer = 0;
        }
    }
}

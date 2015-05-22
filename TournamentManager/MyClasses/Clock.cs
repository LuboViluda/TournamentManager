using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

/// <summary>
/// trieda, ktora si uklada informacie o tyme, napriklad zoznam hracov v tyme, meno tymu, skupinu, atd
/// </summary>

namespace TournamentManager
{
    public class Clock
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Clock(int parMinute, int parSeconds)
        {
            Minutes = parMinute;
            Seconds = parSeconds;
        }

        public void SecondDown()
        {
            if (Seconds == 0 && Minutes == 0)
            {
                return;
            }
            if (Seconds == 0)
            {
                Minutes--;
                Seconds = 59;
            }
            else
            {
                Seconds--;
            }
        }

    }
}

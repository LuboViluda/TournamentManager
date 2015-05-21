using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TournamentManager
{
    public class Save
    {
        public Save(string fileName, List<Match> Matches)
        {           
            string buffer = JsonConvert.SerializeObject(Matches);
            using (var outfile = new StreamWriter(fileName + "_matches.txt"))
            {
                outfile.Write(buffer);
                outfile.Close();
            }
        }
    }
}

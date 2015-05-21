using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TournamentManager
{
    public class Load
    {
        private string FileName;
        public Load(string fileName)
        {
            FileName = fileName;
        }
        public List<Match> LoadMatches()
        {
            string buffer;
            try
            {
                using (var openedFile = new StreamReader(FileName + "_matches.txt"))
                {
                    buffer = openedFile.ReadToEnd();
                    openedFile.Close();
                }
            }
            catch (FileNotFoundException)
            {
                var myNewForm = new WarningEmptyTeamAddForm("File no foud, load matches error");
                myNewForm.ShowDialog();
                return new List<Match>();
            }
            var listOfItems = JsonConvert.DeserializeObject<List<Match>>(buffer);
            return listOfItems;
        }
    }
}

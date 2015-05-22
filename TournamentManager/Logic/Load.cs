using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

/// <summary>
/// trieda, ktora nacita ulozeny turnaj zo suboru
/// </summary>

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
            using (var sr = new StreamReader(FileName + "_matches.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Match>));
                var listOfItems = (List<Match>)xs.Deserialize(sr);
                return listOfItems;
            }         
        }
    }
}

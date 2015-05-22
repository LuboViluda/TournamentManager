using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

/// <summary>
/// trieda, ktora ulozi aktualny turnaj do suboru so zadanym menom a Listov zapasov
/// </summary>

namespace TournamentManager
{
    public class Save
    {
        public Save(string fileName, List<Match> Matches)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Match>));
            TextWriter tw = new StreamWriter(fileName + "_matches.xml");
            xs.Serialize(tw, Matches);
            tw.Close();
        }
    }
}

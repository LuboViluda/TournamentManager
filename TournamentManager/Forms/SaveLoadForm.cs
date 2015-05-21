using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager
{
    public partial class SaveLoadForm : Form
    {
        public List<Team> Teams;
        public List<Player> Players;
        public List<Match> Matches;
        public List<Team> TeamsWomen;
        public List<Player> PlayersWomen;
        private int SaveOrLoad; 
        
        public SaveLoadForm(int saveOrLoad)
        {
            InitializeComponent();
            if (saveOrLoad == 1) 
            {
                // 1 to save, other load
                label1.Text = "Save as...";
            } else 
            {
                label1.Text = "Load file...";
            }
            SaveOrLoad = saveOrLoad;
            //Teams = new List<Team>();
            //Players = new List<Player>();
            Matches = new List<Match>();
            
            //TeamsWomen = new List<Team>();
            //PlayersWomen = new List<Player>();
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (SaveOrLoad == 1)
            {
                var ourSave = new Save(textBox1.Text, Matches);
            }
            else
            {
                var ourLoad = new Load(textBox1.Text);
                Matches = ourLoad.LoadMatches();
                var MensMatches = Matches.Where(t => t.team1.Group == 1 ||
                                                     t.team1.Group == 2 ||
                                                     t.team1.Group == 3 ||
                                                     t.team1.Group == 4);
 /*               foreach (Match m in MensMatches)
                {   // reload teams from matches
                    if (!Teams.Exists(t => t.TeamName == m.team1.TeamName))
                    {
                        Teams.Add(m.team1);
                    }
                    if (!Teams.Exists(t => t.TeamName == m.team2.TeamName))
                    {
                        Teams.Add(m.team2);
                    }
                }
                foreach (Team t in Teams)
                {
                    Players.Add(t.Players[0]);
                    Players.Add(t.Players[1]);
                }

                var WomenMatches = Matches.Where(t => t.team1.Group == 6 ||
                                                      t.team1.Group == 5);

                foreach (Match m in WomenMatches)
                {   // reload teams from matches
                    if (!TeamsWomen.Exists(t => t.TeamName == m.team1.TeamName))
                    {
                        TeamsWomen.Add(m.team1);
                    }
                    if (!TeamsWomen.Exists(t => t.TeamName == m.team2.TeamName))
                    {
                        TeamsWomen.Add(m.team2);
                    }
                }
                foreach (Team t in TeamsWomen)
                {
                    PlayersWomen.Add(t.Players[0]);
                    PlayersWomen.Add(t.Players[1]);
                }
                */
            }
            this.Close();
        }
    }
}

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
    public partial class PlayOff : Form
    {
        public List<Match> PlayOffMatches { get; set; }
        public List<Match> PlayOffMatchesWomen { get; set; }
        public List<Team> Teams { get; set; }
        public List<Team> TeamsWomen { get; set; }
        public List<Player> Players;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 
       
        // Form functions
        public PlayOff(List<Team> parTeams, List<Team> parWomenTeams, List<Player> parPlayers)
        {
            InitializeComponent();
            // inizialize matches
            // disable close(x) button

            Teams = parTeams;
            TeamsWomen = parWomenTeams;
            Players = parPlayers;
            PlayOffMatches = PreparePlayOffMatches();
            PlayOffMatchesWomen = PreparePlayOffWomenMatches();
            
            a1Label.Text = PlayOffMatches[0].team1.TeamName;
            a2Label.Text = PlayOffMatches[0].team2.TeamName;
            b1Label.Text = PlayOffMatches[1].team1.TeamName;
            b2Label.Text = PlayOffMatches[1].team2.TeamName;
            c1Label.Text = PlayOffMatches[2].team1.TeamName;
            c2Label.Text = PlayOffMatches[2].team2.TeamName;
            d1Label.Text = PlayOffMatches[3].team1.TeamName;
            d2Label.Text = PlayOffMatches[3].team2.TeamName;
            
            wom51label.Text = PlayOffMatchesWomen[2].team1.TeamName;
            wom52label.Text = PlayOffMatchesWomen[2].team2.TeamName;

            womQ11label.Text = PlayOffMatchesWomen[0].team1.TeamName;
            womQ12label.Text = PlayOffMatchesWomen[0].team2.TeamName;

            womQ21label.Text = PlayOffMatchesWomen[1].team1.TeamName;
            womQ22label.Text = PlayOffMatchesWomen[1].team2.TeamName;
        }
        private void quarterfinalsA1D2Button_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches[0].Played)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[0].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[0].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[0], team1, team2);
            myNewForm.ShowDialog();
            a1Label.Text = PlayOffMatches[0].team1.TeamName;
            a2Label.Text = PlayOffMatches[0].team2.TeamName;
            q11label.Text = Convert.ToString(PlayOffMatches[0].Team1Goals);
            q12label.Text = Convert.ToString(PlayOffMatches[0].Team2Goals);
            prepareSemifinalMatches();
        }
        private void quarterfinalsC1D2Button_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches[1].Played)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[1].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[1].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[1], team1, team2);
            myNewForm.ShowDialog();
            b1Label.Text = PlayOffMatches[1].team1.TeamName;
            b2Label.Text = PlayOffMatches[1].team2.TeamName;
            q21label.Text = Convert.ToString(PlayOffMatches[1].Team1Goals);
            q22label.Text = Convert.ToString(PlayOffMatches[1].Team2Goals);
            prepareSemifinalMatches();
        }
        private void quarterfinalsD1C2Button_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches[2].Played)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[2].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[2].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[2], team1, team2);
            myNewForm.ShowDialog();
            c1Label.Text = PlayOffMatches[2].team1.TeamName;
            c2Label.Text = PlayOffMatches[2].team2.TeamName;
            q41label.Text = Convert.ToString(PlayOffMatches[2].Team1Goals);
            q42label.Text = Convert.ToString(PlayOffMatches[2].Team2Goals);
            prepareSemifinalMatches();
        }
        private void quarterfinalsA2B1Button_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches[3].Played)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[3].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[3].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[3], team1, team2);
            myNewForm.ShowDialog();
            d1Label.Text = PlayOffMatches[3].team1.TeamName;
            d2Label.Text = PlayOffMatches[3].team2.TeamName;
            q31label.Text = Convert.ToString(PlayOffMatches[3].Team1Goals);
            q32label.Text = Convert.ToString(PlayOffMatches[3].Team2Goals);
            prepareSemifinalMatches();
        }
        private void semifinalsABButton_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches.Count() < 6)
            {
                return;
            }

            if (PlayOffMatches[4].Played || PlayOffMatches.Count() != 6)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[4].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[4].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[4], team1, team2);
            myNewForm.ShowDialog();
            semifinalsABaLabel.Text = Convert.ToString(PlayOffMatches[4].Team1Goals);
            semifinalsABbLabel.Text = Convert.ToString(PlayOffMatches[4].Team2Goals);
            prepareFinalsMatches();
        }
        private void finalsButton_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches.Count() < 8)
            {
                return;
            }

            if (PlayOffMatches[6].Played || PlayOffMatches.Count() != 8)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[6].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[6].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[6], team1, team2);
            myNewForm.ShowDialog();
            final1Label.Text = Convert.ToString(PlayOffMatches[6].Team1Goals);
            final2Label.Text = Convert.ToString(PlayOffMatches[6].Team2Goals);
            if (PlayOffMatches[6].Team1Player1Goals > PlayOffMatches[6].Team1Player2Goals)
            {
                final1WinnerLabel.BackColor = Color.Green;
            }
            else
            {
                final2WinnerLabel.BackColor = Color.Green;

            }

        }
        private void thirdPlaceButton_Click_1(object sender, EventArgs e)
        {
            if (PlayOffMatches.Count() < 8)
            {
                return;
            }

            if (PlayOffMatches[7].Played || PlayOffMatches.Count() != 8)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[7].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[7].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[7], team1, team2);
            myNewForm.ShowDialog();
            thirdPlace1Label.Text =Convert.ToString(PlayOffMatches[7].Team1Goals);
            thirdPlace2Label.Text = Convert.ToString(PlayOffMatches[7].Team2Goals);
        }
        private void semifinalsCDButton_Click(object sender, EventArgs e)
        {
            if (PlayOffMatches.Count() < 6)
            {
                return;
            }

            if (PlayOffMatches[5].Played || PlayOffMatches.Count() != 6)
            {
                return;
            }

            var team1 = Teams.First(t => t.TeamName == PlayOffMatches[5].team1.TeamName);
            var team2 = Teams.First(t => t.TeamName == PlayOffMatches[5].team2.TeamName);
            var myNewForm = new MatchForm(PlayOffMatches[5], team1, team2);
            myNewForm.ShowDialog();
            seminfinalsCDdLabel.Text = PlayOffMatches[5].Team1Goals + " - " + PlayOffMatches[5].Team2Goals;

            seminfinalsCDdLabel.Text = Convert.ToString(PlayOffMatches[5].Team1Goals);
            seminfinalsCDcLabel.Text = Convert.ToString(PlayOffMatches[5].Team2Goals);
            prepareFinalsMatches();
        }

        // My function
        public List<Match> PreparePlayOffMatches()
        {
            var playoffMatches = new List<Match>();

            var group1 = Teams.Where(p => p.Group == 1).ToList();
            group1.Sort();
            var group2 = Teams.Where(p => p.Group == 2).ToList();
            group2.Sort();
            var group3 = Teams.Where(p => p.Group == 3).ToList();
            group3.Sort();
            var group4 = Teams.Where(p => p.Group == 4).ToList();
            group4.Sort();
            playoffMatches.Add(new Match(group1[0], group2[1]));
            playoffMatches.Add(new Match(group3[0], group4[1]));
            playoffMatches.Add(new Match(group3[1], group4[0]));
            playoffMatches.Add(new Match(group1[1], group2[0]));

            return playoffMatches;
        }

        public List<Match> PreparePlayOffWomenMatches()
        {
            var playOffMatchesWomen = new List<Match>();

            var group5 = TeamsWomen.Where(p => p.Group == 5).ToList();
            group5.Sort();
            var group6 = TeamsWomen.Where(p => p.Group == 6).ToList();
            group6.Sort();

            playOffMatchesWomen.Add(new Match(group5[0], group6[1]));
            playOffMatchesWomen.Add(new Match(group5[1], group6[0]));
            playOffMatchesWomen.Add(new Match(group5[2], group6[2]));
            
            return playOffMatchesWomen;
        }
        private void prepareSemifinalMatches()
        {
            if (PlayOffMatches.All(p => p.Played == true && PlayOffMatches.Count() == 4))
            {
                Team winner1 = null;
                Team winner2 = null;

                winner1 = getWinner(PlayOffMatches[0]);
                winner2 = getWinner(PlayOffMatches[1]);
                PlayOffMatches.Add(new Match(winner1, winner2));

                winner1 = getWinner(PlayOffMatches[2]);
                winner2 = getWinner(PlayOffMatches[3]);
                PlayOffMatches.Add(new Match(winner1, winner2));
                // show results
                aNextLabel.Text = PlayOffMatches[4].team1.TeamName;
                bNextLabel.Text = PlayOffMatches[4].team2.TeamName;
                cNextLabel.Text = PlayOffMatches[5].team1.TeamName;
                dNextLabel.Text = PlayOffMatches[5].team2.TeamName;
            }
        }
        private Team getWinner(Match parMatch)
        {
            if (parMatch.Team1Goals > parMatch.Team2Goals)
            {
                return parMatch.team1;
            }
            else
            {
                return parMatch.team2;
            }
        }
        private Team getLosser(Match parMatch)
        {
            if (parMatch.Team1Goals < parMatch.Team2Goals)
            {
                return parMatch.team1;
            }
            else
            {
                return parMatch.team2;
            }
        }
        private void prepareFinalsMatches()
        {
            if (PlayOffMatches.Count(p => p.Played) == 6 && PlayOffMatches.Count() == 6)
            {
                Team winner1 = null;
                Team winner2 = null;
                // about cup
                winner1 = getWinner(PlayOffMatches[4]);
                winner2 = getWinner(PlayOffMatches[5]);
                final1WinnerLabel.Text = winner1.TeamName;
                final2WinnerLabel.Text = winner2.TeamName;
                PlayOffMatches.Add(new Match(winner1, winner2));
                // to 3th possition
                winner1 = getLosser(PlayOffMatches[4]);
                winner2 = getLosser(PlayOffMatches[5]);
                finalLooser1Label.Text = winner1.TeamName;
                final2LooserLabel.Text = winner2.TeamName;
                PlayOffMatches.Add(new Match(winner1, winner2));
            }
        }

        private void prepareWomansFinalsMatches()
        {
            if (PlayOffMatchesWomen.All(p => p.Played) && PlayOffMatchesWomen.Count() == 3)
            {
                Team winner1 = null;
                Team winner2 = null;
                winner1 = getWinner(PlayOffMatchesWomen[0]);
                winner2 = getWinner(PlayOffMatchesWomen[1]);
                womF1label.Text = winner1.TeamName;
                womF2label.Text = winner2.TeamName;
                PlayOffMatchesWomen.Add(new Match(winner1, winner2));

                winner1 = getLosser(PlayOffMatchesWomen[0]);
                winner2 = getLosser(PlayOffMatchesWomen[1]);
                wom31label.Text = winner1.TeamName;
                wom32label.Text = winner2.TeamName;
                PlayOffMatchesWomen.Add(new Match(winner1, winner2));
            }                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PlayOffMatchesWomen[2].Played)
            {
                return;
            }
            var myNewForm = new MatchForm(PlayOffMatchesWomen[2], PlayOffMatches[2].team1, PlayOffMatches[2].team2);
            myNewForm.ShowDialog();

            wom51slabel.Text = Convert.ToString(PlayOffMatchesWomen[2].Team1Goals);
            wom52slabel.Text = Convert.ToString(PlayOffMatchesWomen[2].Team2Goals);
            prepareWomansFinalsMatches();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (PlayOffMatchesWomen[1].Played)
            {
                return;
            }
            var myNewForm = new MatchForm(PlayOffMatchesWomen[1], PlayOffMatches[1].team1, PlayOffMatches[1].team2);
            myNewForm.ShowDialog();
            womQs21label.Text = Convert.ToString(PlayOffMatchesWomen[1].Team1Goals);
            womQs22label.Text = Convert.ToString(PlayOffMatchesWomen[1].Team2Goals);
            prepareWomansFinalsMatches();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (PlayOffMatchesWomen[0].Played)
            {
                return;
            }
            var myNewForm = new MatchForm(PlayOffMatchesWomen[0], PlayOffMatches[0].team1, PlayOffMatches[0].team2);
            myNewForm.ShowDialog();
            womQs11label.Text = Convert.ToString(PlayOffMatchesWomen[0].Team1Goals);
            womQs12label.Text = Convert.ToString(PlayOffMatchesWomen[0].Team2Goals);
            prepareWomansFinalsMatches();
        }

        private void womFinalbutton_Click(object sender, EventArgs e)
        {
            if (PlayOffMatchesWomen.Count() < 4)
            {
                return;
            }
            if (PlayOffMatchesWomen[3].Played)
            {
                return;
            }
            var myNewForm = new MatchForm(PlayOffMatchesWomen[3], PlayOffMatches[3].team1, PlayOffMatches[3].team2);
            myNewForm.ShowDialog();
            womFs1label.Text = Convert.ToString(PlayOffMatchesWomen[3].Team1Goals);
            womFs2label.Text = Convert.ToString(PlayOffMatchesWomen[3].Team2Goals); 
            if (PlayOffMatchesWomen[3].Team1Goals > PlayOffMatchesWomen[3].Team2Goals)
            {
                womF1label.BackColor = Color.Green;
            }
            else
            {
                womF2label.BackColor = Color.Green;
            }

        }

        private void wom3thbutton_Click(object sender, EventArgs e)
        {
            if(PlayOffMatchesWomen.Count() < 4)
            {
                return;
            }
            
            if (PlayOffMatchesWomen[4].Played)
            {
                return;
            }
            var myNewForm = new MatchForm(PlayOffMatchesWomen[4], PlayOffMatchesWomen[4].team1, PlayOffMatchesWomen[4].team2);
            myNewForm.ShowDialog();
            wom31slabel.Text = Convert.ToString(PlayOffMatchesWomen[4].Team1Goals);
            wom32slabel.Text = Convert.ToString(PlayOffMatchesWomen[4].Team2Goals);
        }
    }
}

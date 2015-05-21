using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace TournamentManager
{
    public partial class MatchForm : Form
    {
        public Match Match { get; set; }
        public Team Team1 {get; set;}
        public Team Team2 {get; set;}

        private Clock Clock { get; set; }
        private System.Timers.Timer Timer { get; set; }
        private int Period {get; set;}

        private bool canUndo = false;
        private int lastTeamScored = 0;
        private int lastPlayerScored = 0;

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
        
        public MatchForm(Match match, Team team1, Team team2)
        {
            InitializeComponent();
            Match = match;
            Team1 = team1;
            Team2 = team2;
            Timer = new System.Timers.Timer(1000);
            Clock = new Clock(5, 0);
            Period = 1;
            Timer.Elapsed += new System.Timers.ElapsedEventHandler(EverySecond);
            FinishCloseButton.Text = "Close";
            if (Match.team1.TeamName.Length > 15)
            {
                team1NameLabel.Text = Match.team1.TeamName.Substring(0, 15) + ".";
            }
            else
            {
                team1NameLabel.Text = Match.team1.TeamName;
            }
            if (Match.team2.TeamName.Length > 15)
            {
                team2NameLabel.Text = Match.team2.TeamName.Substring(0, 15) + ".";
            }
            else
            {
                team2NameLabel.Text = Match.team2.TeamName;
            }
            team1Player1ScoreButton.Text = Match.team1.Players[0].Name;
            team1Player2ScoreButton.Text = Match.team1.Players[1].Name;
            team2Player1ScoreButton.Text = Match.team2.Players[0].Name;
            team2Player2ScoreButton.Text = Match.team2.Players[1].Name;
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            Period = 1;
            Timer.Stop();
            Match.Team1Goals = 0;
            Match.Team2Goals = 0;
            Match.Team1Player1Goals = 0;
            Match.Team1Player2Goals = 0;
            Match.Team2Player1Goals = 0;
            Match.Team2Player2Goals = 0;
            Clock.Minutes = 5;
            Clock.Seconds = 0;

            // reflect changes
            periodShowLabel.Text = "I";
            team1ScoreLabel.Text = Convert.ToString(0);
            team2ScoreLabel.Text = Convert.ToString(0);
            ActuallizeTime(Clock.Minutes, Clock.Seconds);
            FinishCloseButton.Text = "Close";
  
        }
        private void startTimebutton_Click(object sender, EventArgs e)
        {
            if (!Timer.Enabled)
            {
                Timer.Start();
            }
        }     
        private void stopButton_Click(object sender, EventArgs e)
        {
            if (Timer.Enabled)
            {
                Timer.Stop();
            }
        }
        private void EverySecond(object source, System.Timers.ElapsedEventArgs e)
        {
            Clock.SecondDown();
            ActuallizeTime(Clock.Minutes, Clock.Seconds);

            if (Clock.Seconds == 0 && Clock.Minutes == 0)
            {
                playSound("sirene");
                if (Timer.Enabled)
                {
                    Timer.Stop();
                }
                if (Period == 1)
                {   // go to the second period
                    Invoke(new Action(() =>
                    {
                        periodShowLabel.Text = "II";
                        timeLabel.Text = "5:00";
                    }));
                    Clock.Minutes = 5;
                    Clock.Seconds = 0;
                    Period = 2;
                }
                else
                {
                    // match ended
                    Invoke(new Action(() =>
                    {
                        FinishCloseButton.Text = "Finish";
                    }));
                }
            }
        }
        private void playSound(string sound_name)
        {
            string temp_sound_name = sound_name + ".wav";
            try
            {
                SoundPlayer sound = new SoundPlayer(temp_sound_name);
                sound.Play();
            }
            catch(Exception ex)
            {
                ex = ex;
                //
            }
        }
        private void team1Player1ScoreButton_Click(object sender, EventArgs e)
        {
            // positive statistics
            canUndo = true;
            lastPlayerScored = 1;
            lastTeamScored = 1;
            Match.Team1Goals++;
            Match.Team1Player1Goals++;
            team1ScoreLabel.Text = Match.Team1Goals.ToString();      // reflect changes

            string name = Match.team1.Players[0].Name;
            playSound(name);
 
        }
        private void team1Player2ScoreButton_Click(object sender, EventArgs e)
        {
            // positive statistics
            canUndo = true;
            lastPlayerScored = 2;
            lastTeamScored = 1;
            Match.Team1Goals++;
            Match.Team1Player2Goals++;
            team1ScoreLabel.Text = Match.Team1Goals.ToString();      // reflect changes          
            string name = Match.team1.Players[1].Name;
            playSound(name);
        }
        private void team2Player1ScoreButton_Click(object sender, EventArgs e)
        {
            // positive statistics
            canUndo = true;
            lastPlayerScored = 1;
            lastTeamScored = 2;
            Match.Team2Goals++;
            Match.Team2Player1Goals++;
            team2ScoreLabel.Text = Match.Team2Goals.ToString();      // reflect changes
            playSound(Match.team2.Players[0].Name);
        }
        private void team2Player2ScoreButton_Click(object sender, EventArgs e)
        {
            // positive statistics
            canUndo = true;
            lastPlayerScored = 2;
            lastTeamScored = 2;
            Match.Team2Goals++;
            Match.Team2Player2Goals++;
            team2ScoreLabel.Text = Match.Team2Goals.ToString();      // reflect changes
            playSound(Match.team1.Players[1].Name);
        }
        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (Period == 2 && Clock.Minutes == 0 && Clock.Seconds == 0)
            {   // reflect changes from match to players and teams stats          
                
                Match.Played = true;
                // teamstats actuallize
                Team1.GF += Match.Team1Goals;
                Team1.GA += Match.Team2Goals;
                Team1.Diff += Match.Team1Goals - Match.Team2Goals;
                Team1.GP++;
                Team2.GF += Match.Team2Goals;
                Team2.GA += Match.Team1Goals;
                Team2.Diff += Match.Team2Goals - Match.Team1Goals;
                Team2.GP++;
                // actualize playersstats team1
                Team1.Players[0].GFbyPlayer += Match.Team1Player1Goals;
                Team1.Players[1].GFbyPlayer += Match.Team1Player2Goals;
                Team1.Players[0].GAbyPlayer += Match.Team2Goals;
                Team1.Players[1].GAbyPlayer += Match.Team2Goals;
                Team1.Players[0].GP++;
                Team1.Players[1].GP++;
                // actualize playerstats team2
                Team2.Players[0].GFbyPlayer += Match.Team2Player1Goals;
                Team2.Players[1].GFbyPlayer += Match.Team2Player2Goals;
                Team2.Players[0].GAbyPlayer += Match.Team1Goals;
                Team2.Players[1].GAbyPlayer += Match.Team1Goals;
                Team2.Players[0].GP++;
                Team2.Players[1].GP++;

                if (Match.Team1Goals > Match.Team2Goals)
                {   //team1 win
                    Team1.Points += 3;
                }
                if (Match.Team1Goals < Match.Team2Goals)
                {   // team2 win
                    Team2.Points += 3;

                }
                if (Match.Team1Goals == Match.Team2Goals)
                {   //draw
                    Team1.Points += 1;
                    Team2.Points += 1;
                }
            }
            else
            {   // close the
                resetButton_Click(null, null);
            }
            Close();
        }
        private void ActuallizeTime(int Minutes, int Seconds)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    if (Seconds > 9)
                    {   // seconds time formating
                        timeLabel.Text = Convert.ToString(Minutes) + ":" + Convert.ToString(Seconds);
                    }
                    else
                    {
                        timeLabel.Text = Convert.ToString(Minutes) + ":0" + Convert.ToString(Seconds);
                    }

                }));
            }
            catch (ObjectDisposedException)
            {
            }
        }
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (canUndo)
            {
                canUndo = false;
                if (lastTeamScored == 1) 
                {
                    Match.Team1Goals--;
                    if (lastPlayerScored == 1)
                    {
                        Match.Team1Player1Goals--;
                    }
                    if (lastPlayerScored == 2) 
                    {
                        Match.Team1Player2Goals--;
                    }
                    team1ScoreLabel.Text = Match.Team1Goals.ToString();
                }
                if (lastTeamScored == 2)
                {
                    Match.Team2Goals--;
                    if (lastPlayerScored == 1)
                    {
                        Match.Team2Player1Goals--;
                    }
                    if (lastPlayerScored == 2)
                    {
                        Match.Team2Player2Goals--;
                    }
                    team2ScoreLabel.Text = Match.Team2Goals.ToString();
                }       
            }
        }

    }
}

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
    public partial class AddTeamsForm : Form
    {
        public List<Team> Teams;
        public List<Player> Players;
        public List<Team> TeamsWomen;
        public List<Player> PlayersWomen;

        private int CurrentBasket { get; set; }

        public AddTeamsForm()
        {
            InitializeComponent();
            CurrentBasket = 1;
        }
        private void buttonCloseAddTeamsForm_Click(object sender, EventArgs e)
        {
            foreach (var t in Teams.ToList())
            {
                Teams.Remove(t);
            }
            foreach (var t in Players.ToList())
            {
                Players.Remove(t);
            }
            foreach (var t in PlayersWomen)
            {
                PlayersWomen.Remove(t);
            }
            foreach(var t in TeamsWomen)
            {
                TeamsWomen.Remove(t);
            }
            Close();
        }
        private void buttonNextTeam_Click(object sender, EventArgs e)
        {
            // check input data from textBoxes
            if (CheckTeamNameUnique() &&
                CheckPlayerNameUnique() &&
                CheckParamsArentNull() &&
                ParamsLength(textBoxTeamName.Text, textBox1PlayerName.Text, textBox2PlayerName.Text))
            {   // if correct add new team else show dialog window (in function)
                var player1 = new Player(textBox1PlayerName.Text);
                var player2 = new Player(textBox2PlayerName.Text);
                if (16 > Teams.Count())
                {
                    Players.Add(player1);
                    Players.Add(player2);
                    Teams.Add(new Team(textBoxTeamName.Text, player1, player2, CurrentBasket));
                }
                else
                {
                    PlayersWomen.Add(player1);
                    PlayersWomen.Add(player2);
                    TeamsWomen.Add(new Team(textBoxTeamName.Text, player1, player2, -1));
                }
                RefreshTextBoxs();
            }

            if (Teams.Count == 16 && TeamsWomen != null && TeamsWomen.Count == 6)
            {
                var warningForm = new WarningEmptyTeamAddForm("Toss teams to the basket");
                warningForm.ShowDialog();
                this.Close();
            }
        }
        private bool CheckTeamNameUnique()
        {
            if ((Teams.Where(p => p.TeamName == textBoxTeamName.Text).Count() > 0)
                && (TeamsWomen.Where(p => p.TeamName == textBoxTeamName.Text).Count() > 0))
            {   // is unique
                var warningForm = new WarningEmptyTeamAddForm("Team name isn't unique");
                warningForm.ShowDialog();
                return false;
            }
            return true;
        }
        private bool CheckParamsArentNull()
        {
            if (String.IsNullOrEmpty(textBoxTeamName.Text) || String.IsNullOrEmpty(textBox1PlayerName.Text) ||
            String.IsNullOrEmpty(textBox2PlayerName.Text))
            {   //  isn't null
                var warningForm = new WarningEmptyTeamAddForm("Please add all information");
                warningForm.ShowDialog();
                return false;
            }
            return true;
        }
        private bool CheckPlayerNameUnique()
        {
            WarningEmptyTeamAddForm warningForm;
            if (textBox1PlayerName.Text == textBox2PlayerName.Text)
            {
                warningForm = new WarningEmptyTeamAddForm("Player1 name is same as Player2 name");
                warningForm.Show();
                return false;
            }

            if (Players.Where(p => p.Name == textBox1PlayerName.Text).Count() > 0)
            {
                warningForm = new WarningEmptyTeamAddForm("Player1 name isn't unique");
                warningForm.Show();
                return false;
            }

            if (PlayersWomen != null && (PlayersWomen.Where(p => p.Name == textBox1PlayerName.Text).Count() > 0))
            {
                warningForm = new WarningEmptyTeamAddForm("Player1 name isn't unique");
                warningForm.Show();
                return false;
            }
            if ((Players.Where(p => p.Name == textBox2PlayerName.Text).Count() > 0))
            {
                warningForm = new WarningEmptyTeamAddForm("Player2 name isn't unique");
                warningForm.Show();
                return false;
            }

            if (PlayersWomen != null && PlayersWomen.Where(p => p.Name == textBox2PlayerName.Text).Count() > 0)
            {
                warningForm = new WarningEmptyTeamAddForm("Player1 name isn't unique");
                warningForm.Show();
                return false;
            }
            return true;
        }
        private bool ParamsLength(string teamName, string player1Name, string player2Name)
        {      // another possibily hide or override Text.Append();
            if (32 < textBoxTeamName.Text.Length || 20 < textBox1PlayerName.Text.Length || 20 < textBox2PlayerName.Text.Length)
            {
                var warningForm = new WarningEmptyTeamAddForm("Text params max 14 chars lenght");
                warningForm.Show();
                return false;
            }
            return true;
        }
        private void RefreshTextBoxs()
        {
            textBoxTeamName.Text = "";
            textBox1PlayerName.Text = "";
            textBox2PlayerName.Text = "";
            
            if(Teams.Count < 16)
            {
                labelCapacityTeams.Text = (Teams.Count).ToString() + "/16";
                labelBasketInfo.Text = "Mens Team to basket " + CurrentBasket.ToString() + "/4";
            }
            else
            {
                if (TeamsWomen != null)
                {
                    labelCapacityTeams.Text = TeamsWomen.Count.ToString() + "/6";
                }
                else
                {
                    labelCapacityTeams.Text = "0" + "/6";
                }
                
                labelBasketInfo.Text = "Women Teams";
            }
            if (0 == (Teams.Count % 4))
            {   // after 4 teams upgrade basket to toss
                CurrentBasket++;
            }
        }
    }
}

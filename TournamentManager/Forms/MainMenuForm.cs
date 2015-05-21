using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TournamentManager
{
    public partial class MainMenuForm : Form
    {
        public List<Team> TeamsMens;
        public List<Player> PlayersMens;
        public List<Team> TeamsWomen;
        public List<Player> PlayersWomen;
        public List<Match> Matches;

        //Funcion calling by form
        public MainMenuForm()
        {
            InitializeComponent();
            TeamsMens = new List<Team>();          
            PlayersMens = new List<Player>();
            TeamsWomen = new List<Team>();
            PlayersWomen = new List<Player>();
            Matches = new List<Match>();

            /*
            TeamsMens.Add(new Team("MazúrBorci", new Player("Andrej Mazúr"), new Player("Robo Mazúr"), 1));
            TeamsMens.Add(new Team("SÝPNI", new Player("Ľubo Viluda"), new Player("Peter Mravec"), 2));
            TeamsMens.Add(new Team("Kajnšmetke team", new Player("Vladimír Vavrek"), new Player("Peter Slanina"), 3));
            TeamsMens.Add(new Team("Rape team", new Player("Roman Pivovarník"), new Player("hrac1"), 4));
            for (int i = 0; i < 4; i++ )
            {
                TeamsMens[i].Group = 1;
            }

            TeamsMens.Add(new Team("Návrat posledných jednorožcov", new Player("Dušan Gorčák"), new Player("Michal Piják"), 1));
            TeamsMens.Add(new Team("Lahôdkové tofu", new Player("Matúš Burda"), new Player("Šani Lorinc"), 2));
            TeamsMens.Add(new Team("MIXTEJP", new Player("Daniel Briš"), new Player("Jakub Katrák"), 3));
            TeamsMens.Add(new Team("Rajders", new Player("Roland Botka"), new Player("Pavol Lupták"), 4));
            for (int i = 4; i < 8; i++)
            {
                TeamsMens[i].Group = 2;
            }

            TeamsMens.Add(new Team("Tukabel", new Player("Tomáš Maslonka"), new Player("Tomáš Píš"), 1));
            TeamsMens.Add(new Team("David a Zidan", new Player("Tomáš Marton"), new Player("Lukáš Vojt"), 2));
            TeamsMens.Add(new Team("Slepí Špišiaci", new Player("Juraj Pramuka"), new Player("Jakub Čekovský"), 3));
            TeamsMens.Add(new Team("Bad Boys", new Player("Štefan Svinčiak"), new Player("Martin Pavlech"), 4));
            for (int i = 8; i < 12; i++)
            {
                TeamsMens[i].Group =3;
            }
            
            TeamsMens.Add(new Team("Jeden a pol bakalára", new Player("Peter Urdzík"), new Player("Michal Fotta"), 1));
            TeamsMens.Add(new Team("Monika a Štefka", new Player("Martin Fulier"), new Player("Juraj Štyrák"), 2));
            TeamsMens.Add(new Team("////////", new Player("Matej Štefánik"), new Player("Peter Chochula"), 3));
            TeamsMens.Add(new Team("Pcha Pcho Pche", new Player("Tomáš Durčák"), new Player("Matúš Dzurjo"), 4));
            for (int i = 12; i < 16; i++)
            {
                TeamsMens[i].Group = 4;
            }

            TeamsWomen.Add(new Team("Čajky", new Player("Ivet Žilincová"), new Player("Lucia Ručková"), 0));
            TeamsWomen.Add(new Team("Čo ti JiBe", new Player("Bea Štupáková"), new Player("Jíťa Kolářová"), 0));
            TeamsWomen.Add(new Team("Nepoznané", new Player("Katka Chalupecká"), new Player("Monika Kuzmová"), 0));
            for (int i = 0; i < 3; i++)
            {
                TeamsWomen[i].Group = 5;
            }

            TeamsWomen.Add(new Team("XL", new Player("Lucia Žovinová"), new Player("Xénia Kušnátová"), 0));
            TeamsWomen.Add(new Team("Horalky", new Player("Zuzka Pazdičová"), new Player("Teri Skatuloková"), 0));
            TeamsWomen.Add(new Team("Rogerove Micky", new Player("Doris Žigová"), new Player("Romana Krnáčová"), 0));
            for (int i = 3; i < 6; i++)
            {
                TeamsWomen[i].Group = 6;
            }
            

            Add4Matches(0, 3);
            AddWomenMatch(5, 0, 1);
            Add4Matches(1, 2);
            AddWomenMatch(6, 0, 1);
            Add4Matches(0, 2);
            AddWomenMatch(5, 1, 2);
            Add4Matches(2, 3);
            AddWomenMatch(6, 1, 2);
            Add4Matches(1, 3);
            AddWomenMatch(5, 0, 2);
            Add4Matches(0, 1);
            AddWomenMatch(6, 0, 2);
            */

            string[] times = new string[] 
            { "08:00", "08:15", "08:30", "08:45",
              "09:00", "09:15", "09:30", "09:45",
              "10:00", "10:15", "10:30", "10:45",
              "11:00", "11:15", "11:30", "11:45",
              "12:00", "12:15", "12:30", "12:45",
              "13:00", "13:15", "13:30", "13:45",
              "14:00", "14:15", "14:30", "14:45",
              "15:00", "15:15"
            };

            string buffer = "";
            int o = 0;
            foreach (Match m in Matches)
            {
                buffer += times[o] + " - " + m.team1.TeamName + " vs. " + m.team2.TeamName + Environment.NewLine;
                o++;
            }

            using (var outfile = new StreamWriter("zapasy.txt"))
            {
                outfile.Write(buffer);
                outfile.Close();
            }

            var MensMatches = Matches.Where(t => t.team1.Group == 1 ||
                                     t.team1.Group == 2 ||
                                     t.team1.Group == 3 ||
                                     t.team1.Group == 4);
            foreach (Match m in MensMatches)
            {   // reload teams from matches
                if (!TeamsMens.Exists(t => t.TeamName == m.team1.TeamName))
                {
                    TeamsMens.Add(m.team1);
                }
                if (!TeamsMens.Exists(t => t.TeamName == m.team2.TeamName))
                {
                    TeamsMens.Add(m.team2);
                }
            }
            foreach (Team t in TeamsMens)
            {
                PlayersMens.Add(t.Players[0]);
                PlayersMens.Add(t.Players[1]);
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
            ReloadMainMenu();
        }
        private void newTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myNewForm = new AddTeamsForm();
            myNewForm.Teams = this.TeamsMens;
            myNewForm.Players = this.PlayersMens;
            myNewForm.TeamsWomen = this.TeamsWomen;
            myNewForm.PlayersWomen = this.PlayersWomen;
            myNewForm.ShowDialog();

            if (TeamsMens.Count() == 16  && TeamsWomen.Count() == 6)
            {
                TossGroups();
                PrepareMatches();
                ReloadMainMenu();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myNewForm = new SaveLoadForm(1);
            myNewForm.Teams = this.TeamsMens;
            myNewForm.Players = this.PlayersMens;
            myNewForm.Matches = this.Matches;
            myNewForm.TeamsWomen = this.TeamsWomen;
            myNewForm.PlayersWomen = this.PlayersWomen;
            myNewForm.ShowDialog();

            new Save("save_plocha", Matches);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myNewForm = new SaveLoadForm(2);
            myNewForm.ShowDialog();

            TeamsMens = new List<Team>();
            TeamsWomen = new List<Team>();
            PlayersWomen = new List<Player>();
            PlayersMens = new List<Player>();
            Matches = new List<Match>();

            this.Matches = myNewForm.Matches;

            var MensMatches = Matches.Where(t => t.team1.Group == 1 ||
                                     t.team1.Group == 2 ||
                                     t.team1.Group == 3 ||
                                     t.team1.Group == 4);
            foreach (Match m in MensMatches)
            {   // reload teams from matches
                if (!TeamsMens.Exists(t => t.TeamName == m.team1.TeamName))
                {
                    Team new_team = m.team1;
                    TeamsMens.Add(new_team);
                }
                if (!TeamsMens.Exists(t => t.TeamName == m.team2.TeamName))
                {
                    Team new_team = m.team2;
                    TeamsMens.Add(new_team);
                }
            }

            foreach (Team t in TeamsMens)
            {
                PlayersMens.Add(t.Players[0]);
                PlayersMens.Add(t.Players[1]);
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

            if (this.TeamsMens.Count != 0 && PlayersMens.Count() != 0 && Matches.Count() != 0)
            {   // load sucess ?
                ReloadMainMenu();
            }

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void playPlayOff_Click(object sender, EventArgs e)
        {
            if (Matches.Where(p => p.Played == false).Count() == 0 &&
                Matches.Count() != 0)
            {   // all match played? and has some matches
                var myNewForm = new PlayOff(TeamsMens, TeamsWomen, PlayersMens);
                myNewForm.Show();
                ReloadPlayerTables();
            }
            else
            {
                var myNewForm = new WarningEmptyTeamAddForm("No all match was played, can't play playoff");
                myNewForm.Show();
            }

        }

        //My functions
        private void TossGroups()
        {
            var rnd = new Random();
            int rndNumber = rnd.Next();

            for (int u = 1; u < 5; u++)
            {
                for (int i = 1; i < 5; i++)
                {
                    var filtred = TeamsMens.Where(t => t.Basket == i && t.Group == 0);
                    var one = filtred.ElementAt(rndNumber % filtred.Count()).Group = u;
                }
            }

            for (int u = 1; u <= 3; u++)
            {
                for (int i = 5; i <= 6; i++)
                {
                    var filtred = TeamsWomen.Where(t => t.Group == 0);
                    var one = filtred.ElementAt(rndNumber % filtred.Count()).Group = i;
                }
            }
        }
        private void PrepareMatches()
        {
            Matches = new List<Match>();
            Add4Matches(0, 1);
            AddWomenMatch(5, 0, 1);
            Add4Matches(2, 3);
            AddWomenMatch(6, 0, 1);
            Add4Matches(0, 2);
            AddWomenMatch(5, 1, 2);
            Add4Matches(1, 3);
            AddWomenMatch(6, 1, 2);
            Add4Matches(0, 3);
            AddWomenMatch(5,0, 2);
            Add4Matches(1, 2);
            AddWomenMatch(6, 0, 2);
            string[] times = new string[] 
            { "08:00", "08:15", "08:30", "08:45",
              "09:00", "09:15", "09:30", "09:45",
              "10:00", "10:15", "10:30", "10:45",
              "11:00", "11:15", "11:30", "11:45",
              "12:00", "12:15", "12:30", "12:45",
              "13:00", "13:15", "13:30", "13:45",
              "14:00", "14:15", "14:30", "14:45",
              "15:00", "15:15"
            };


            string buffer = "";
            int o = 0;
            foreach (Match m in Matches)
            {
                buffer += times[o] + " - " + m.team1.TeamName + " vs. " + m.team2.TeamName + Environment.NewLine;
                o++;
            }


            using (var outfile = new StreamWriter("zapasy.txt"))
            {
                outfile.Write(buffer);
                outfile.Close();
            }
        }
        private void Add4Matches(int team1, int team2)
        {
            var group1Teams = TeamsMens.Where(p => p.Group == 1).ToArray();
            var group2Teams = TeamsMens.Where(p => p.Group == 2).ToArray();
            var group3Teams = TeamsMens.Where(p => p.Group == 3).ToArray();
            var group4Teams = TeamsMens.Where(p => p.Group == 4).ToArray();
            
            Matches.Add(new Match(group1Teams[team1], group1Teams[team2]));
            Matches.Add(new Match(group2Teams[team1], group2Teams[team2]));
            Matches.Add(new Match(group3Teams[team1], group3Teams[team2]));
            Matches.Add(new Match(group4Teams[team1], group4Teams[team2]));   
        }
        private void AddWomenMatch(int group, int team1, int team2)
        {
            var temp_teams = TeamsWomen.Where(p => p.Group == group).ToArray();
            Matches.Add(new Match(temp_teams[team1], temp_teams[team2]));
        }
        private void ReloadMainMenu()
        {
            ReloadGroupTables();
            ReloadPlayerTables();
            ReloadMatches();
            RealoadMatchesTable();
        }
        private void ReloadGroupTables()
        {
            List<Team> oneGroup = TeamsMens.Where(t => t.Group == 1).ToList();
            oneGroup.Sort();
            ClearRowsInTable(dataGridTable1);
            foreach (var t in oneGroup)
            {
                dataGridTable1.Rows.Add(t.TeamName, t.GP, t.GA, t.GF, t.Diff, t.Points);
            }

            oneGroup = TeamsMens.Where(t => t.Group == 2).ToList();
            oneGroup.Sort();
            ClearRowsInTable(dataGridTable2);
            foreach (var t in oneGroup)
            {
                dataGridTable2.Rows.Add(t.TeamName, t.GP, t.GA, t.GF, t.Diff, t.Points);
            }

            oneGroup = TeamsMens.Where(t => t.Group == 3).ToList();
            oneGroup.Sort();
            ClearRowsInTable(dataGridTable3);
            foreach (var t in oneGroup)
            {
                dataGridTable3.Rows.Add(t.TeamName, t.GP, t.GA, t.GF, t.Diff, t.Points);
            }
            oneGroup = TeamsMens.Where(t => t.Group == 4).ToList();
            oneGroup.Sort();

            ClearRowsInTable(dataGridTable4);
            foreach (var t in oneGroup)
            {
                dataGridTable4.Rows.Add(t.TeamName, t.GP, t.GA, t.GF, t.Diff, t.Points);
            }

            oneGroup = TeamsWomen.Where(t => t.Group == 5).ToList();
            oneGroup.Sort();

            ClearRowsInTable(dataGridTableWomen1);
            foreach (var t in oneGroup)
            {
                dataGridTableWomen1.Rows.Add(t.TeamName, t.GP, t.GA, t.GF, t.Diff, t.Points);
            }

            oneGroup = TeamsWomen.Where(t => t.Group == 6).ToList();
            oneGroup.Sort();

            ClearRowsInTable(dataGridTableWomen2);
            foreach (var t in oneGroup)
            {
                dataGridTableWomen2.Rows.Add(t.TeamName, t.GP, t.GA, t.GF, t.Diff, t.Points);
            }   
        }
        private void RealoadMatchesTable()
        {
            ClearRowsInTable(dataGridView1);
            foreach (var t in Matches)
            {
                if (t.Played)
                {
                    dataGridView1.Rows.Add(t.team1.TeamName, t.team2.TeamName, t.Team1Goals.ToString() + ":" + t.Team2Goals.ToString());
                } 
                else
                {
                    dataGridView1.Rows.Add(t.team1.TeamName, t.team2.TeamName, "---");  
                }               
            }
        }
        private void ClearRowsInTable(DataGridView table)
        {
            for (int i = table.RowCount - 1; i >= 0; i--)
            {
                var row = table.Rows[i];
                table.Rows.Remove(row);
            }
        }
        private void ReloadPlayerTables()
        {
            List<Player> players = PlayersMens.ToList();
            players.Sort(CompareForBestScorer);
            ClearRowsInTable(dataGridViewPlayers1);
            foreach (var t in players)
            {
                if (t.GP > 0)
                    dataGridViewPlayers1.Rows.Add(t.Name, t.GFbyPlayer, t.GP, Math.Round(Convert.ToDouble(t.GFbyPlayer) / Convert.ToDouble(t.GP), 2));
                else
                    dataGridViewPlayers1.Rows.Add(t.Name, t.GFbyPlayer, t.GP, "-");
            }

            players.Sort(CompareForBestDefensman);
            ClearRowsInTable(dataGridViewPlayers2);
            foreach (var t in players)
            {
                if (t.GP > 0)
                    dataGridViewPlayers2.Rows.Add(t.Name, t.GAbyPlayer, t.GP, Math.Round(Convert.ToDouble(t.GAbyPlayer) / Convert.ToDouble(t.GP), 2));
                else
                    dataGridViewPlayers2.Rows.Add(t.Name, t.GAbyPlayer, t.GP, "-");
            }
        }
        private void ReloadMatches()
        {
            Label[] labels = new Label[] { labelMatch1, labelMatch2, labelMatch3, labelMatch4, labelMatch5 };
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = "";
            }
            if (Matches.Count() == 0)
            {
                return;
            }

            var unplayedMatches = Matches.Where(p => p.Played == false).ToArray();
            for (int i = 0; (i < 5 && i < unplayedMatches.Count()); i++)
            {
                labels[i].Text = unplayedMatches[i].team1.TeamName + " vs. " + unplayedMatches[i].team2.TeamName;
            }


        }
        public static int CompareForBestScorer(Player first, Player other)
        {
            // the highest priority more goals
            if (first.GFbyPlayer > other.GFbyPlayer)
            {
                return -1;
            }
            if (other.GFbyPlayer > first.GFbyPlayer)
            {
                return 1;
            }
            
            // second goals / Gp
            if (first.GFbyPlayer == other.GFbyPlayer)
            {
                if(first.GP > other.GP)
                {
                    return 1;
                }
                if(first.GP < other.GP)
                {
                    return -1;
                }
            }
            return 0;
        }
        public static int CompareForBestDefensman(Player first, Player other)
        {        
            if (first.GP != 0 && other.GP != 0)
            {
                double a = Convert.ToDouble(first.GAbyPlayer) / Convert.ToDouble(first.GP);
                double b = Convert.ToDouble(other.GAbyPlayer) / Convert.ToDouble(other.GP);
                if (a == b)
                {
                    if (first.GFbyPlayer > other.GFbyPlayer)
                    {
                        return 1;
                    }
                    if (first.GFbyPlayer < other.GFbyPlayer)
                    {
                        return -1;
                    }
                    if (first.GP > other.GP)
                    {
                        return -1;
                    }
                    if (first.GP < other.GP)
                    {
                        return 1;
                    }
                    return 0;
                }


                if (a < b)
                {
                    return -1;
                }
                else
                {
                    if (b < a)
                    {
                        return 1;
                    }
                }
            }
            if (first.GP == 0 && other.GP != 0)
            {
                return 1;
            }
            if (other.GP == 0 && first.GP != 0)
            {
                return -1;
            }
            return 0;
        }
        private void RunMatch(Match ourMatch, Team team1, Team team2)
        {
            var myNewForm = new MatchForm(ourMatch, team1, team2);
            myNewForm.ShowDialog();
            if (ourMatch.Played)
            {
                new Save("backup_" + Matches.Count(t => t.Played).ToString(), Matches);
            }
            ReloadMainMenu();
        }
        private void playButton1_Click(object sender, EventArgs e)
        {
            var ourMatches = Matches.Where(p => p.Played == false).ToArray();
            if (ourMatches.Count() < 1)
            {
                var warningForm = new WarningEmptyTeamAddForm("ERROR: No match to play");
                warningForm.ShowDialog();
                return;
            }

            Team team1, team2;
            if (ourMatches[0].team1.Group == 5 ||  ourMatches[0].team1.Group == 6)
            {
                team1 = TeamsWomen.First(t => t.TeamName == ourMatches[0].team1.TeamName);
                team2 = TeamsWomen.First(t => t.TeamName == ourMatches[0].team2.TeamName);    
            } else 
            {
                team1 = TeamsMens.First(t => t.TeamName == ourMatches[0].team1.TeamName);
                team2 = TeamsMens.First(t => t.TeamName == ourMatches[0].team2.TeamName);
            }
            
            RunMatch(ourMatches[0], team1, team2);
        }
        private void playButton2_Click(object sender, EventArgs e)
        {
            var ourMatches = Matches.Where(p => p.Played == false).ToArray();
            if (ourMatches.Count() < 2)
            {
                var warningForm = new WarningEmptyTeamAddForm("ERROR: No match to play");
                warningForm.ShowDialog();
                return;
            }
            Team team1, team2;
            if (ourMatches[1].team1.Group == 5 || ourMatches[1].team1.Group == 6)
            {
                team1 = TeamsWomen.First(t => t.TeamName == ourMatches[1].team1.TeamName);
                team2 = TeamsWomen.First(t => t.TeamName == ourMatches[1].team2.TeamName);
            }
            else
            {
                team1 = TeamsMens.First(t => t.TeamName == ourMatches[1].team1.TeamName);
                team2 = TeamsMens.First(t => t.TeamName == ourMatches[1].team2.TeamName);
            }

            RunMatch(ourMatches[1], team1, team2);
        }
        private void playButton3_Click(object sender, EventArgs e)
        {
            var ourMatches = Matches.Where(p => p.Played == false).ToArray();
            if (ourMatches.Count() < 3)
            {
                var warningForm = new WarningEmptyTeamAddForm("ERROR: No match to play");
                warningForm.ShowDialog();
                return;
            }
            Team team1, team2;
            if (ourMatches[2].team1.Group == 5 || ourMatches[2].team1.Group == 6)
            {
                team1 = TeamsWomen.First(t => t.TeamName == ourMatches[2].team1.TeamName);
                team2 = TeamsWomen.First(t => t.TeamName == ourMatches[2].team2.TeamName);
            }
            else
            {
                team1 = TeamsMens.First(t => t.TeamName == ourMatches[2].team1.TeamName);
                team2 = TeamsMens.First(t => t.TeamName == ourMatches[2].team2.TeamName);
            }

            RunMatch(ourMatches[2], team1, team2);
        }
        private void playButton4_Click(object sender, EventArgs e)
        {
            var ourMatches = Matches.Where(p => p.Played == false).ToArray();
            if (ourMatches.Count() < 4)
            {
                var warningForm = new WarningEmptyTeamAddForm("ERROR: No match to play");
                warningForm.ShowDialog();
                return;
            }
            Team team1, team2;
            if (ourMatches[3].team1.Group == 5 || ourMatches[3].team1.Group == 6)
            {
                team1 = TeamsWomen.First(t => t.TeamName == ourMatches[3].team1.TeamName);
                team2 = TeamsWomen.First(t => t.TeamName == ourMatches[3].team2.TeamName);
            }
            else
            {
                team1 = TeamsMens.First(t => t.TeamName == ourMatches[3].team1.TeamName);
                team2 = TeamsMens.First(t => t.TeamName == ourMatches[3].team2.TeamName);
            }

            RunMatch(ourMatches[3], team1, team2);
        }
        private void playButton5_Click(object sender, EventArgs e)
        {
            var ourMatches = Matches.Where(p => p.Played == false).ToArray();
            if (ourMatches.Count() < 5)
            {
                var warningForm = new WarningEmptyTeamAddForm("ERROR: No match to play");
                warningForm.ShowDialog();
                return;
            }
            Team team1, team2;
            if (ourMatches[4].team1.Group == 5 || ourMatches[4].team1.Group == 6)
            {
                team1 = TeamsWomen.First(t => t.TeamName == ourMatches[4].team1.TeamName);
                team2 = TeamsWomen.First(t => t.TeamName == ourMatches[4].team2.TeamName);
            }
            else
            {
                team1 = TeamsMens.First(t => t.TeamName == ourMatches[4].team1.TeamName);
                team2 = TeamsMens.First(t => t.TeamName == ourMatches[4].team2.TeamName);
            }

            RunMatch(ourMatches[4], team1, team2);
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
        private void reloadPlayersStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadPlayerTables();
        }

    }
}

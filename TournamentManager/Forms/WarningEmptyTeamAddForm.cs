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
    public partial class WarningEmptyTeamAddForm : Form
    {
        public WarningEmptyTeamAddForm(string warningText)
        {
            InitializeComponent();
            labelTextWarning.Text = warningText;
        }
        private void buttonCloseWarning_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSoftware
{
    public partial class FormHelp : Form
    {
        public FormHelp(ApplicationMode am)
        {
            InitializeComponent();

            if (am == ApplicationMode.ADMIN_MODE)
            { this.BackgroundImage = Properties.Resources.help_admin; }
            else if (am == ApplicationMode.SEARCH_MODE)
            { this.BackgroundImage = Properties.Resources.help_search; }
            else if (am == ApplicationMode.VOTER_VERIFICATION_MODE)
            { this.BackgroundImage = Properties.Resources.help_verification; }
            else if (am == ApplicationMode.VOTER_VOTE_MODE)
            { this.BackgroundImage = Properties.Resources.help_vote; }
            else if (am == ApplicationMode.RESULT_MODE)
            { this.BackgroundImage = Properties.Resources.help_result; }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

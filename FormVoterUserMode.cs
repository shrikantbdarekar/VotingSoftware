using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VotingSoftware
{
    public partial class FormVoterUserMode : Form
    {
        private SoundPlayer spSelect, spExit;


        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (textPassword.Text.Equals("!@#$"))
                this.Close();
            else
            {
                MessageBox.Show("Invalid Password!");
                panelExit.Visible = true;
            }
        }

        private void buttonVotingRoom_Click(object sender, EventArgs e)
        {
            FormVotingAction frm = new FormVotingAction();
            frm.ShowDialog();

            panelExit.Visible = true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }

        private void FormVoterUserMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.E))
            {
                panelExit.Visible = true;
                textPassword.Focus();
            }
        }

        private void FormVoterUserMode_Load(object sender, EventArgs e)
        {
            panelExit.Visible = false;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp(ApplicationMode.VOTER_VOTE_MODE);
            frm.ShowDialog();
        }

        private void buttonVotingRoom_Enter(object sender, EventArgs e)
        {
            spSelect.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        private void buttonVotingRoom_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        public FormVoterUserMode()
        {
            InitializeComponent();
            spSelect = new SoundPlayer(Properties.Resources.menu_change_2);
            spExit = new SoundPlayer(Properties.Resources.form_exit_1);
        }
    }
}

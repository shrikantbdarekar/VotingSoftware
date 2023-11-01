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
    public partial class FormActiveMode : Form
    {
        private SoundPlayer spSelect, spExit;

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormAdminMode frm = new FormAdminMode();
            frm.ShowDialog();
        }

        private void buttonGeneralUSer_Click(object sender, EventArgs e)
        {
            FormGeneralUserMode frm = new FormGeneralUserMode();
            frm.ShowDialog();
        }

        private void buttonVoteAdmin_Click(object sender, EventArgs e)
        {
            FormVoterAdminMode frm = new FormVoterAdminMode();
            frm.ShowDialog();
        }

        private void buttonVoteTransaction_Click(object sender, EventArgs e)
        {
            FormVoterUserMode frm = new FormVoterUserMode();
            frm.ShowDialog();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            FormResultMode frm = new FormResultMode();
            frm.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        private void buttonAdmin_Enter(object sender, EventArgs e)
        {
            spSelect.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        public FormActiveMode()
        {
            InitializeComponent();

            spSelect = new SoundPlayer(Properties.Resources.menu_change_2);
            spExit = new SoundPlayer(Properties.Resources.form_exit_1);
        }
    }
}

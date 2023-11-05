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
    public partial class FormAdminMode : Form
    {
        private SoundPlayer spSelect, spExit;

        public FormAdminMode()
        {
            InitializeComponent();
            spSelect = new SoundPlayer(Properties.Resources.menu_change_2);
            spExit = new SoundPlayer(Properties.Resources.form_exit_1);
        }

        private void buttonPanelDetails_Enter(object sender, EventArgs e)
        {
            spSelect.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        private void buttonPanelDetails_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        private void buttonPanelDetails_Click(object sender, EventArgs e)
        {
            FormPanelDetails frm = new FormPanelDetails();
            frm.ShowDialog();
        }

        private void buttonCandidateDetails_Click(object sender, EventArgs e)
        {
            FormCandidateDetails frm = new FormCandidateDetails();
            frm.ShowDialog();
        }

        private void buttonWardDetails_Click(object sender, EventArgs e)
        {
            FormAreaDetails frm = new FormAreaDetails();
            frm.ShowDialog();
        }

        private void buttonVoterDetails_Click(object sender, EventArgs e)
        {
            FormVoterDetails frm = new FormVoterDetails();
            frm.ShowDialog();
        }

        private void buttonPrepareElectionData_Click(object sender, EventArgs e)
        {
            FormPrepareElectionData frm = new FormPrepareElectionData();
            frm.ShowDialog();
        }

        private void buttonElectionSettings_Click(object sender, EventArgs e)
        {
            FormElectionSettings frm = new FormElectionSettings();
            frm.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp(ApplicationMode.ADMIN_MODE);
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //spExit.Play();
            FormMessage frm = new FormMessage("Do you want to Exit?", MessageBoxButtons.YesNo, false);
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class FormResultMode : Form
    {
        private SoundPlayer spSelect, spExit;

        private void buttonResultOverall_Click(object sender, EventArgs e)
        {
            FormResultGeneral frm = new FormResultGeneral();
            frm.ShowDialog();
        }

        private void buttonREsultPanelwise_Click(object sender, EventArgs e)
        {
            FormResultPanelwise frm = new FormResultPanelwise();
            frm.ShowDialog();
        }

        private void buttonResultGraphical_Click(object sender, EventArgs e)
        {
            FormResultGraphs frm = new FormResultGraphs();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormResultVotingPercentage frm = new FormResultVotingPercentage();
            frm.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp(ApplicationMode.RESULT_MODE);
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

        private void buttonResultOverall_Enter(object sender, EventArgs e)
        {
            spSelect.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        private void buttonResultOverall_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        public FormResultMode()
        {
            InitializeComponent();
            //spSelect = new SoundPlayer(Properties.Resources.buzz);
            spSelect = new SoundPlayer(Properties.Resources.menu_change_2);
            spExit = new SoundPlayer(Properties.Resources.form_exit_1);

        }
    }
}

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
    public partial class FormGeneralUserMode : Form
    {
        private SoundPlayer spSelect, spExit;

        private void buttonSearchVoter_Click(object sender, EventArgs e)
        {
            FormSearchVoter frm = new FormSearchVoter();
            frm.ShowDialog();
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp(ApplicationMode.SEARCH_MODE);
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMessage frm = new FormMessage("Do you want to Exit?", MessageBoxButtons.YesNo, false);
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonSearchVoter_Enter(object sender, EventArgs e)
        {
            spSelect.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        private void buttonSearchVoter_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        public FormGeneralUserMode()
        {
            InitializeComponent();
            spSelect = new SoundPlayer(Properties.Resources.menu_change_2);
            spExit = new SoundPlayer(Properties.Resources.form_exit_1);

        }
    }
}

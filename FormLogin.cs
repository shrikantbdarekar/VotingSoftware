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
    public partial class FormLogin : Form
    {
        private SoundPlayer spSelect, spWelcome;
        bool IsLoaded = false;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (comboActiveMode.SelectedItem == null)
            {
                MessageBox.Show("Please, specify your machine role!");
                comboActiveMode.Focus();
                return;
                //Program.MyMode = ApplicationMode.GENERAL_MODULE;
            }
            else
            {
                Program.MyMode = (ApplicationMode)comboActiveMode.SelectedItem;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Program.ContinueExit = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonLogin_Enter(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                spSelect.Play();
                ((Button)sender).BackgroundImage = Properties.Resources.a_2;
            }
        }

        private void buttonLogin_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                spWelcome.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.DoEvents();
            IsLoaded = true;
        }

        public FormLogin()
        {
            InitializeComponent();
            spSelect = new SoundPlayer(Properties.Resources.msg_2);
            spWelcome = new SoundPlayer(Properties.Resources.result);

            comboActiveMode.Items.Add(ApplicationMode.ADMIN_MODE);
            comboActiveMode.Items.Add(ApplicationMode.SEARCH_MODE);
            comboActiveMode.Items.Add(ApplicationMode.VOTER_VERIFICATION_MODE);
            comboActiveMode.Items.Add(ApplicationMode.VOTER_VOTE_MODE);
            comboActiveMode.Items.Add(ApplicationMode.RESULT_MODE);

            ToolTip tt = new ToolTip();
            tt.SetToolTip(comboActiveMode, "Select your work-mode.");
        }
    }
}

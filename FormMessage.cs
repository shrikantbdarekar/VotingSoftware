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
    public partial class FormMessage : Form
    {
        private SoundPlayer spSelect1, spExit1;
        private bool IsAutoTimer;
        private MessageBoxButtons MessageBoxButtons1;

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void FormMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            if (IsAutoTimer)
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonYes_Enter(object sender, EventArgs e)
        {
            spSelect1.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        private void buttonYes_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        public FormMessage(string Message, MessageBoxButtons msgButtons, bool IsAutoTimer)
        {
            InitializeComponent();

            spSelect1 = new SoundPlayer(Properties.Resources.msg_2);
            spExit1 = new SoundPlayer(Properties.Resources.form_exit_1);
            this.IsAutoTimer = IsAutoTimer;

            labelMessage.Text = Message;
            MessageBoxButtons1 = msgButtons;
            if (msgButtons == MessageBoxButtons.YesNo)
            {
                buttonOk.Visible = false;
            }
            else if (msgButtons == MessageBoxButtons.OK)
            {
                buttonYes.Visible = false;
                buttonNo.Visible = false;
            }
        }
    }
}

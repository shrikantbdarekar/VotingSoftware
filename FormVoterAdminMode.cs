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
    public partial class FormVoterAdminMode : Form
    {
        private SoundPlayer spSelect, spExit;
        private string TokenId;

        private void buttonVoterVerification_Click(object sender, EventArgs e)
        {
            //FormVotingAction frm = new FormVotingAction();
            //frm.ShowDialog();
            FormVoterVerification frm = new FormVoterVerification();
            frm.ShowDialog();
            //TokenId = frm.TokenId;
            //if (TokenId != "")
            //{
            //    MyDataClass MyDataClassIssueToken;
            //    string sql = "select * from token_manager";
            //    MyDataClassIssueToken = new MyDataClass(sql, "token_manager");
            //    MyDataClassIssueToken.AddNew();
            //    MyDataClassIssueToken.CurrentRow["token_no"] = TokenId;
            //    MyDataClassIssueToken.CurrentRow["token_status"] = "EMPTY";//FILLED
            //    MyDataClassIssueToken.SaveCurrentRow();
            //    MessageBox.Show("Applied for token...");
            //}
        }

        private void buttonIssueToken_Click(object sender, EventArgs e)
        {
            //string sql = "select count(*) from token_manager where token_status='EMPTY'";
            //int tokenCnt = Convert.ToInt32(AutoSerial.GetSerial(sql));

            //if (tokenCnt == 1)//here 1 means zero.
            //{
            //    MessageBox.Show("Failed to generate token id! Plz. check voter verification.");
            //    return;
            //}

            FormIssueToken frm = new FormIssueToken("");
            frm.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp(ApplicationMode.VOTER_VERIFICATION_MODE);
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

        private void buttonVoterVerification_Enter(object sender, EventArgs e)
        {
            spSelect.Play();
            ((Button)sender).BackgroundImage = Properties.Resources.a_2;
        }

        private void buttonVoterVerification_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.a_1;
        }

        public FormVoterAdminMode()
        {
            InitializeComponent();
            spSelect = new SoundPlayer(Properties.Resources.menu_change_2);
            spExit = new SoundPlayer(Properties.Resources.form_exit_1);
        }
    }
}

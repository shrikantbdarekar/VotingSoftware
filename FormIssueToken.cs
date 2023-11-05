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
    public partial class FormIssueToken : Form
    {
        private SoundPlayer spWelcome;
        //private MyDataClass MyDataClassIssueToken;
        private string TokenId = "";

        public FormIssueToken(string TId)
        {
            InitializeComponent();

            spWelcome = new SoundPlayer(Properties.Resources.result);
            //TokenId = TId;

            //string sql = "select * from token_manager ";
            //string sql = "select * from token_manager where token_status='EMPTY'";
            //MyDataClassIssueToken = new MyDataClass(sql, "token_manager");
        }

        private void FormIssueToken_Load(object sender, EventArgs e)
        {
            spWelcome.PlayLooping();
        }

        private void buttonIssue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Token Issued Successfully.");
            this.Close();
        }
    }
}

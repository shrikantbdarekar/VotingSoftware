using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSoftware
{
    static class Program
    {

        public static ApplicationMode MyMode;
        public static bool ContinueExit;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormBackground frmb = new FormBackground();
            frmb.Show();

            ContinueExit = false;
            while (!ContinueExit)
            {
                FormLogin frm1 = new FormLogin();
                frm1.ShowDialog();
                if (frm1.DialogResult == DialogResult.Cancel)
                    //Application.Exit();
                    return;

                if (MyMode == null)
                    MyMode = ApplicationMode.GENERAL_MODULE;

                if (MyMode == ApplicationMode.GENERAL_MODULE)
                {
                    FormActiveMode frm = new FormActiveMode();
                    frm.ShowDialog();
                }
                else if (MyMode == ApplicationMode.ADMIN_MODE)
                {
                    FormAdminMode frm = new FormAdminMode();
                    frm.ShowDialog();
                }
                else if (MyMode == ApplicationMode.RESULT_MODE)
                {
                    FormResultMode frm = new FormResultMode();
                    frm.ShowDialog();
                }
                else if (MyMode == ApplicationMode.SEARCH_MODE)
                {
                    FormGeneralUserMode frm = new FormGeneralUserMode();
                    frm.ShowDialog();
                }
                else if (MyMode == ApplicationMode.VOTER_VERIFICATION_MODE)
                {
                    FormVoterAdminMode frm = new FormVoterAdminMode();
                    frm.ShowDialog();
                }
                else if (MyMode == ApplicationMode.VOTER_VOTE_MODE)
                {
                    FormVoterUserMode frm = new FormVoterUserMode();
                    frm.ShowDialog();
                }
            }


            //Application.Run(new FormLogin());
        }
    }
}


namespace VotingSoftware
{
    partial class FormVoterAdminMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoterAdminMode));
            this.buttonIssueToken = new System.Windows.Forms.Button();
            this.buttonVoterVerification = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIssueToken
            // 
            this.buttonIssueToken.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.buttonIssueToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIssueToken.FlatAppearance.BorderSize = 0;
            this.buttonIssueToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIssueToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssueToken.ForeColor = System.Drawing.Color.White;
            this.buttonIssueToken.Location = new System.Drawing.Point(14, 86);
            this.buttonIssueToken.Name = "buttonIssueToken";
            this.buttonIssueToken.Size = new System.Drawing.Size(223, 37);
            this.buttonIssueToken.TabIndex = 5;
            this.buttonIssueToken.Text = "Issue Token";
            this.buttonIssueToken.UseVisualStyleBackColor = true;
            this.buttonIssueToken.Click += new System.EventHandler(this.buttonIssueToken_Click);
            this.buttonIssueToken.Enter += new System.EventHandler(this.buttonVoterVerification_Enter);
            this.buttonIssueToken.Leave += new System.EventHandler(this.buttonVoterVerification_Leave);
            // 
            // buttonVoterVerification
            // 
            this.buttonVoterVerification.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.buttonVoterVerification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVoterVerification.FlatAppearance.BorderSize = 0;
            this.buttonVoterVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoterVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoterVerification.ForeColor = System.Drawing.Color.White;
            this.buttonVoterVerification.Location = new System.Drawing.Point(13, 44);
            this.buttonVoterVerification.Name = "buttonVoterVerification";
            this.buttonVoterVerification.Size = new System.Drawing.Size(223, 37);
            this.buttonVoterVerification.TabIndex = 4;
            this.buttonVoterVerification.Text = "Voter Verification";
            this.buttonVoterVerification.UseVisualStyleBackColor = true;
            this.buttonVoterVerification.Click += new System.EventHandler(this.buttonVoterVerification_Click);
            this.buttonVoterVerification.Enter += new System.EventHandler(this.buttonVoterVerification_Enter);
            this.buttonVoterVerification.Leave += new System.EventHandler(this.buttonVoterVerification_Leave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(13, 171);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(223, 37);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.Enter += new System.EventHandler(this.buttonVoterVerification_Enter);
            this.buttonExit.Leave += new System.EventHandler(this.buttonVoterVerification_Leave);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(13, 128);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(223, 37);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.Enter += new System.EventHandler(this.buttonVoterVerification_Enter);
            this.buttonHelp.Leave += new System.EventHandler(this.buttonVoterVerification_Leave);
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Yellow;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(250, 39);
            this.labelHeading.TabIndex = 8;
            this.labelHeading.Text = "Voting Admin";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVoterAdminMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 228);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonIssueToken);
            this.Controls.Add(this.buttonVoterVerification);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVoterAdminMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVoterAdminMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIssueToken;
        private System.Windows.Forms.Button buttonVoterVerification;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelHeading;
    }
}
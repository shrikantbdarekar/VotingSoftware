
namespace VotingSoftware
{
    partial class FormVoterUserMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoterUserMode));
            this.panelExit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonVotingRoom = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.Transparent;
            this.panelExit.Controls.Add(this.label1);
            this.panelExit.Controls.Add(this.textPassword);
            this.panelExit.Controls.Add(this.buttonExit);
            this.panelExit.Location = new System.Drawing.Point(1, 44);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(248, 144);
            this.panelExit.TabIndex = 10;
            this.panelExit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTER PASSWORD TO EXIT";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(76, 49);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '@';
            this.textPassword.Size = new System.Drawing.Size(94, 24);
            this.textPassword.TabIndex = 3;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(12, 87);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(223, 37);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.Enter += new System.EventHandler(this.buttonVotingRoom_Enter);
            this.buttonExit.Leave += new System.EventHandler(this.buttonVotingRoom_Leave);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(14, 100);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(223, 37);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.Enter += new System.EventHandler(this.buttonVotingRoom_Enter);
            this.buttonHelp.Leave += new System.EventHandler(this.buttonVotingRoom_Leave);
            // 
            // buttonVotingRoom
            // 
            this.buttonVotingRoom.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.buttonVotingRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVotingRoom.FlatAppearance.BorderSize = 0;
            this.buttonVotingRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVotingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVotingRoom.ForeColor = System.Drawing.Color.White;
            this.buttonVotingRoom.Location = new System.Drawing.Point(14, 57);
            this.buttonVotingRoom.Name = "buttonVotingRoom";
            this.buttonVotingRoom.Size = new System.Drawing.Size(223, 37);
            this.buttonVotingRoom.TabIndex = 8;
            this.buttonVotingRoom.Text = "Enter Voting Room";
            this.buttonVotingRoom.UseVisualStyleBackColor = true;
            this.buttonVotingRoom.Click += new System.EventHandler(this.buttonVotingRoom_Click);
            this.buttonVotingRoom.Enter += new System.EventHandler(this.buttonVotingRoom_Enter);
            this.buttonVotingRoom.Leave += new System.EventHandler(this.buttonVotingRoom_Leave);
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.CausesValidation = false;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Yellow;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(250, 39);
            this.labelHeading.TabIndex = 12;
            this.labelHeading.Text = "Voting Room";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Enter += new System.EventHandler(this.buttonVotingRoom_Enter);
            this.button1.Leave += new System.EventHandler(this.buttonVotingRoom_Leave);
            // 
            // FormVoterUserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 190);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonVotingRoom);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormVoterUserMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVoterUserMode";
            this.Load += new System.EventHandler(this.FormVoterUserMode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVoterUserMode_KeyDown);
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonVotingRoom;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button button1;
    }
}
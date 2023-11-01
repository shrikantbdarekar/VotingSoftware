
namespace VotingSoftware
{
    partial class FormGeneralUserMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneralUserMode));
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSearchVoter = new System.Windows.Forms.Button();
            this.buttonSearchCandidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Yellow;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(249, 39);
            this.labelHeading.TabIndex = 14;
            this.labelHeading.Text = "Search";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(12, 128);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(223, 37);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(12, 85);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(223, 37);
            this.buttonHelp.TabIndex = 12;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonSearchVoter
            // 
            this.buttonSearchVoter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchVoter.BackgroundImage")));
            this.buttonSearchVoter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchVoter.FlatAppearance.BorderSize = 0;
            this.buttonSearchVoter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchVoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchVoter.ForeColor = System.Drawing.Color.White;
            this.buttonSearchVoter.Location = new System.Drawing.Point(12, 42);
            this.buttonSearchVoter.Name = "buttonSearchVoter";
            this.buttonSearchVoter.Size = new System.Drawing.Size(223, 37);
            this.buttonSearchVoter.TabIndex = 11;
            this.buttonSearchVoter.Text = "Search Voter";
            this.buttonSearchVoter.UseVisualStyleBackColor = true;
            // 
            // buttonSearchCandidate
            // 
            this.buttonSearchCandidate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchCandidate.BackgroundImage")));
            this.buttonSearchCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchCandidate.FlatAppearance.BorderSize = 0;
            this.buttonSearchCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchCandidate.ForeColor = System.Drawing.Color.White;
            this.buttonSearchCandidate.Location = new System.Drawing.Point(12, 42);
            this.buttonSearchCandidate.Name = "buttonSearchCandidate";
            this.buttonSearchCandidate.Size = new System.Drawing.Size(223, 37);
            this.buttonSearchCandidate.TabIndex = 10;
            this.buttonSearchCandidate.Text = "Search Candidate";
            this.buttonSearchCandidate.UseVisualStyleBackColor = true;
            this.buttonSearchCandidate.Visible = false;
            // 
            // FormGeneralUserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(249, 184);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSearchVoter);
            this.Controls.Add(this.buttonSearchCandidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGeneralUserMode";
            this.Text = "FormGeneralUserMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSearchVoter;
        private System.Windows.Forms.Button buttonSearchCandidate;
    }
}
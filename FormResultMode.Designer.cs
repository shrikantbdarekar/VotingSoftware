
namespace VotingSoftware
{
    partial class FormResultMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultMode));
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonResultGraphical = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonREsultPanelwise = new System.Windows.Forms.Button();
            this.buttonResultOverall = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
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
            this.labelHeading.TabIndex = 13;
            this.labelHeading.Text = "Result";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResultGraphical
            // 
            this.buttonResultGraphical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResultGraphical.BackgroundImage")));
            this.buttonResultGraphical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResultGraphical.FlatAppearance.BorderSize = 0;
            this.buttonResultGraphical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResultGraphical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultGraphical.ForeColor = System.Drawing.Color.White;
            this.buttonResultGraphical.Location = new System.Drawing.Point(12, 130);
            this.buttonResultGraphical.Name = "buttonResultGraphical";
            this.buttonResultGraphical.Size = new System.Drawing.Size(223, 37);
            this.buttonResultGraphical.TabIndex = 9;
            this.buttonResultGraphical.Text = "Graphical Result";
            this.buttonResultGraphical.UseVisualStyleBackColor = true;
            this.buttonResultGraphical.Click += new System.EventHandler(this.buttonResultGraphical_Click);
            this.buttonResultGraphical.Enter += new System.EventHandler(this.buttonResultOverall_Enter);
            this.buttonResultGraphical.Leave += new System.EventHandler(this.buttonResultOverall_Leave);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Voting Percentage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.buttonResultOverall_Enter);
            this.button2.Leave += new System.EventHandler(this.buttonResultOverall_Leave);
            // 
            // buttonREsultPanelwise
            // 
            this.buttonREsultPanelwise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonREsultPanelwise.BackgroundImage")));
            this.buttonREsultPanelwise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonREsultPanelwise.FlatAppearance.BorderSize = 0;
            this.buttonREsultPanelwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonREsultPanelwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonREsultPanelwise.ForeColor = System.Drawing.Color.White;
            this.buttonREsultPanelwise.Location = new System.Drawing.Point(13, 87);
            this.buttonREsultPanelwise.Name = "buttonREsultPanelwise";
            this.buttonREsultPanelwise.Size = new System.Drawing.Size(223, 37);
            this.buttonREsultPanelwise.TabIndex = 8;
            this.buttonREsultPanelwise.Text = "Panelwise Result";
            this.buttonREsultPanelwise.UseVisualStyleBackColor = true;
            this.buttonREsultPanelwise.Click += new System.EventHandler(this.buttonREsultPanelwise_Click);
            this.buttonREsultPanelwise.Enter += new System.EventHandler(this.buttonResultOverall_Enter);
            this.buttonREsultPanelwise.Leave += new System.EventHandler(this.buttonResultOverall_Leave);
            // 
            // buttonResultOverall
            // 
            this.buttonResultOverall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResultOverall.BackgroundImage")));
            this.buttonResultOverall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResultOverall.FlatAppearance.BorderSize = 0;
            this.buttonResultOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResultOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultOverall.ForeColor = System.Drawing.Color.White;
            this.buttonResultOverall.Location = new System.Drawing.Point(12, 44);
            this.buttonResultOverall.Name = "buttonResultOverall";
            this.buttonResultOverall.Size = new System.Drawing.Size(223, 37);
            this.buttonResultOverall.TabIndex = 7;
            this.buttonResultOverall.Text = "Overall Result ";
            this.buttonResultOverall.UseVisualStyleBackColor = true;
            this.buttonResultOverall.Click += new System.EventHandler(this.buttonResultOverall_Click);
            this.buttonResultOverall.Enter += new System.EventHandler(this.buttonResultOverall_Enter);
            this.buttonResultOverall.Leave += new System.EventHandler(this.buttonResultOverall_Leave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(12, 259);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(223, 37);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.Enter += new System.EventHandler(this.buttonResultOverall_Enter);
            this.buttonExit.Leave += new System.EventHandler(this.buttonResultOverall_Leave);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(12, 216);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(223, 37);
            this.buttonHelp.TabIndex = 11;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.Enter += new System.EventHandler(this.buttonResultOverall_Enter);
            this.buttonHelp.Leave += new System.EventHandler(this.buttonResultOverall_Leave);
            // 
            // FormResultMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(249, 316);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonResultGraphical);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonREsultPanelwise);
            this.Controls.Add(this.buttonResultOverall);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResultMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonResultGraphical;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonREsultPanelwise;
        private System.Windows.Forms.Button buttonResultOverall;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
    }
}
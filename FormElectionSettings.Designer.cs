
namespace VotingSoftware
{
    partial class FormElectionSettings
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownVotingPeriod = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalPositionCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEnableVotingTimer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVotingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPositionCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(623, 39);
            this.panelTop.TabIndex = 29;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(623, 39);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Election Settings";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(139, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 39);
            this.panel3.TabIndex = 28;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(230, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(149, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownVotingPeriod);
            this.panel1.Controls.Add(this.numericUpDownTotalPositionCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboEnableVotingTimer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(139, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 116);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "1 sec = 1000";
            // 
            // numericUpDownVotingPeriod
            // 
            this.numericUpDownVotingPeriod.Location = new System.Drawing.Point(160, 74);
            this.numericUpDownVotingPeriod.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.numericUpDownVotingPeriod.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownVotingPeriod.Name = "numericUpDownVotingPeriod";
            this.numericUpDownVotingPeriod.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownVotingPeriod.TabIndex = 2;
            this.numericUpDownVotingPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownVotingPeriod.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownTotalPositionCount
            // 
            this.numericUpDownTotalPositionCount.Location = new System.Drawing.Point(162, 19);
            this.numericUpDownTotalPositionCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownTotalPositionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTotalPositionCount.Name = "numericUpDownTotalPositionCount";
            this.numericUpDownTotalPositionCount.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownTotalPositionCount.TabIndex = 0;
            this.numericUpDownTotalPositionCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTotalPositionCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Positions Count";
            // 
            // comboEnableVotingTimer
            // 
            this.comboEnableVotingTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnableVotingTimer.FormattingEnabled = true;
            this.comboEnableVotingTimer.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.comboEnableVotingTimer.Location = new System.Drawing.Point(160, 45);
            this.comboEnableVotingTimer.Name = "comboEnableVotingTimer";
            this.comboEnableVotingTimer.Size = new System.Drawing.Size(62, 21);
            this.comboEnableVotingTimer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enable Voting Timer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Voting Period";
            // 
            // FormElectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 431);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormElectionSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormElectionSettings";
            this.panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVotingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPositionCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownVotingPeriod;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalPositionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEnableVotingTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
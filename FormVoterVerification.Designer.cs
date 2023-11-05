
namespace VotingSoftware
{
    partial class FormVoterVerification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUpdateVerification = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboVerificationStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvVoterVerification = new System.Windows.Forms.DataGridView();
            this.dgcVoterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVoterPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.comboVerificationRemark = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textSearchVoterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboSearchWardNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textVoterId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboWardNo = new System.Windows.Forms.ComboBox();
            this.textVoterName = new System.Windows.Forms.TextBox();
            this.textContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoterVerification)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(731, 453);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 16);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Verifyed List";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(293, 64);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUpdateVerification
            // 
            this.buttonUpdateVerification.Location = new System.Drawing.Point(152, 64);
            this.buttonUpdateVerification.Name = "buttonUpdateVerification";
            this.buttonUpdateVerification.Size = new System.Drawing.Size(139, 23);
            this.buttonUpdateVerification.TabIndex = 11;
            this.buttonUpdateVerification.Text = "&Update Verification";
            this.buttonUpdateVerification.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Verification Status";
            // 
            // comboVerificationStatus
            // 
            this.comboVerificationStatus.FormattingEnabled = true;
            this.comboVerificationStatus.Items.AddRange(new object[] {
            "COMPLETE",
            "INCOMPLETE",
            "NOT VERIFYED"});
            this.comboVerificationStatus.Location = new System.Drawing.Point(124, 10);
            this.comboVerificationStatus.Name = "comboVerificationStatus";
            this.comboVerificationStatus.Size = new System.Drawing.Size(292, 21);
            this.comboVerificationStatus.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Verification Remark";
            // 
            // dgvVoterVerification
            // 
            this.dgvVoterVerification.AllowUserToAddRows = false;
            this.dgvVoterVerification.AllowUserToDeleteRows = false;
            this.dgvVoterVerification.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvVoterVerification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVoterVerification.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoterVerification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVoterVerification.ColumnHeadersHeight = 28;
            this.dgvVoterVerification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVoterVerification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcVoterName,
            this.dgcVoterPhoto});
            this.dgvVoterVerification.EnableHeadersVisualStyles = false;
            this.dgvVoterVerification.Location = new System.Drawing.Point(12, 51);
            this.dgvVoterVerification.MultiSelect = false;
            this.dgvVoterVerification.Name = "dgvVoterVerification";
            this.dgvVoterVerification.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoterVerification.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVoterVerification.RowHeadersWidth = 35;
            this.dgvVoterVerification.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVoterVerification.RowTemplate.Height = 130;
            this.dgvVoterVerification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoterVerification.Size = new System.Drawing.Size(377, 442);
            this.dgvVoterVerification.TabIndex = 39;
            // 
            // dgcVoterName
            // 
            this.dgcVoterName.DataPropertyName = "voter_name";
            this.dgcVoterName.HeaderText = "Voter Name";
            this.dgcVoterName.Name = "dgcVoterName";
            this.dgcVoterName.ReadOnly = true;
            this.dgcVoterName.Width = 200;
            // 
            // dgcVoterPhoto
            // 
            this.dgcVoterPhoto.DataPropertyName = "voter_photo_thumb";
            this.dgcVoterPhoto.HeaderText = "Photo";
            this.dgcVoterPhoto.Name = "dgcVoterPhoto";
            this.dgcVoterPhoto.ReadOnly = true;
            this.dgcVoterPhoto.Width = 130;
            // 
            // comboVerificationRemark
            // 
            this.comboVerificationRemark.FormattingEnabled = true;
            this.comboVerificationRemark.Items.AddRange(new object[] {
            "VOTING CARD",
            "DRIVING LICENCE",
            "RASHAN CARD",
            "PASSPORT"});
            this.comboVerificationRemark.Location = new System.Drawing.Point(124, 38);
            this.comboVerificationRemark.Name = "comboVerificationRemark";
            this.comboVerificationRemark.Size = new System.Drawing.Size(292, 21);
            this.comboVerificationRemark.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboVerificationRemark);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.buttonUpdateVerification);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboVerificationStatus);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(395, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 101);
            this.panel3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Voter Id";
            // 
            // textSearchVoterName
            // 
            this.textSearchVoterName.Location = new System.Drawing.Point(120, 36);
            this.textSearchVoterName.Name = "textSearchVoterName";
            this.textSearchVoterName.Size = new System.Drawing.Size(296, 20);
            this.textSearchVoterName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Candidate Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(418, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Verification Remark : Identity proof document name etc.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textSearchVoterName);
            this.panel2.Controls.Add(this.comboSearchWardNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(395, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 101);
            this.panel2.TabIndex = 40;
            // 
            // comboSearchWardNo
            // 
            this.comboSearchWardNo.FormattingEnabled = true;
            this.comboSearchWardNo.Location = new System.Drawing.Point(120, 63);
            this.comboSearchWardNo.Name = "comboSearchWardNo";
            this.comboSearchWardNo.Size = new System.Drawing.Size(121, 21);
            this.comboSearchWardNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ward No.";
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(844, 39);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Voter Verification";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.White;
            this.textAddress.Location = new System.Drawing.Point(105, 63);
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.Size = new System.Drawing.Size(311, 20);
            this.textAddress.TabIndex = 5;
            this.textAddress.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textVoterId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboWardNo);
            this.panel1.Controls.Add(this.textVoterName);
            this.panel1.Controls.Add(this.textContactNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Location = new System.Drawing.Point(395, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 148);
            this.panel1.TabIndex = 41;
            // 
            // textVoterId
            // 
            this.textVoterId.BackColor = System.Drawing.Color.White;
            this.textVoterId.Location = new System.Drawing.Point(105, 11);
            this.textVoterId.Name = "textVoterId";
            this.textVoterId.ReadOnly = true;
            this.textVoterId.Size = new System.Drawing.Size(100, 20);
            this.textVoterId.TabIndex = 1;
            this.textVoterId.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ward";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // comboWardNo
            // 
            this.comboWardNo.BackColor = System.Drawing.Color.White;
            this.comboWardNo.Enabled = false;
            this.comboWardNo.FormattingEnabled = true;
            this.comboWardNo.Location = new System.Drawing.Point(105, 115);
            this.comboWardNo.Name = "comboWardNo";
            this.comboWardNo.Size = new System.Drawing.Size(311, 21);
            this.comboWardNo.TabIndex = 8;
            // 
            // textVoterName
            // 
            this.textVoterName.BackColor = System.Drawing.Color.White;
            this.textVoterName.Location = new System.Drawing.Point(105, 37);
            this.textVoterName.Name = "textVoterName";
            this.textVoterName.ReadOnly = true;
            this.textVoterName.Size = new System.Drawing.Size(311, 20);
            this.textVoterName.TabIndex = 3;
            this.textVoterName.TabStop = false;
            // 
            // textContactNo
            // 
            this.textContactNo.BackColor = System.Drawing.Color.White;
            this.textContactNo.Location = new System.Drawing.Point(105, 89);
            this.textContactNo.Name = "textContactNo";
            this.textContactNo.ReadOnly = true;
            this.textContactNo.Size = new System.Drawing.Size(311, 20);
            this.textContactNo.TabIndex = 7;
            this.textContactNo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact no";
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(844, 39);
            this.panelTop.TabIndex = 44;
            // 
            // FormVoterVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 499);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dgvVoterVerification);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVoterVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVoterVerification";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoterVerification)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdateVerification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboVerificationStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvVoterVerification;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVoterName;
        private System.Windows.Forms.DataGridViewImageColumn dgcVoterPhoto;
        private System.Windows.Forms.ComboBox comboVerificationRemark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSearchVoterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboSearchWardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textVoterId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboWardNo;
        private System.Windows.Forms.TextBox textVoterName;
        private System.Windows.Forms.TextBox textContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTop;
    }
}
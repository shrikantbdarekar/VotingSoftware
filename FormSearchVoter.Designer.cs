
namespace VotingSoftware
{
    partial class FormSearchVoter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dgvVoterDetails = new System.Windows.Forms.DataGridView();
            this.dgcVoterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVoterPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textVoterId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboWardNo = new System.Windows.Forms.ComboBox();
            this.textVoterName = new System.Windows.Forms.TextBox();
            this.textContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textSearchVoterName = new System.Windows.Forms.TextBox();
            this.comboSearchWardNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textRoomNo = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoterDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(844, 39);
            this.panelTop.TabIndex = 27;
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
            this.labelHeading.Text = "Search Voter";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(739, 360);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 45;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dgvVoterDetails
            // 
            this.dgvVoterDetails.AllowUserToAddRows = false;
            this.dgvVoterDetails.AllowUserToDeleteRows = false;
            this.dgvVoterDetails.AllowUserToResizeColumns = false;
            this.dgvVoterDetails.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvVoterDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVoterDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoterDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVoterDetails.ColumnHeadersHeight = 28;
            this.dgvVoterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVoterDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcVoterName,
            this.dgcVoterPhoto});
            this.dgvVoterDetails.EnableHeadersVisualStyles = false;
            this.dgvVoterDetails.Location = new System.Drawing.Point(14, 46);
            this.dgvVoterDetails.MultiSelect = false;
            this.dgvVoterDetails.Name = "dgvVoterDetails";
            this.dgvVoterDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoterDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVoterDetails.RowHeadersWidth = 35;
            this.dgvVoterDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVoterDetails.RowTemplate.Height = 130;
            this.dgvVoterDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoterDetails.Size = new System.Drawing.Size(377, 442);
            this.dgvVoterDetails.TabIndex = 44;
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
            this.panel1.Location = new System.Drawing.Point(397, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 148);
            this.panel1.TabIndex = 43;
            // 
            // textVoterId
            // 
            this.textVoterId.Location = new System.Drawing.Point(105, 11);
            this.textVoterId.Name = "textVoterId";
            this.textVoterId.Size = new System.Drawing.Size(100, 20);
            this.textVoterId.TabIndex = 1;
            this.textVoterId.TabStop = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voter Name";
            // 
            // comboWardNo
            // 
            this.comboWardNo.FormattingEnabled = true;
            this.comboWardNo.Location = new System.Drawing.Point(105, 115);
            this.comboWardNo.Name = "comboWardNo";
            this.comboWardNo.Size = new System.Drawing.Size(311, 21);
            this.comboWardNo.TabIndex = 8;
            // 
            // textVoterName
            // 
            this.textVoterName.Location = new System.Drawing.Point(105, 37);
            this.textVoterName.Name = "textVoterName";
            this.textVoterName.Size = new System.Drawing.Size(311, 20);
            this.textVoterName.TabIndex = 3;
            this.textVoterName.TabStop = false;
            // 
            // textContactNo
            // 
            this.textContactNo.Location = new System.Drawing.Point(105, 89);
            this.textContactNo.Name = "textContactNo";
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
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(105, 63);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(311, 20);
            this.textAddress.TabIndex = 5;
            this.textAddress.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(397, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 101);
            this.panel2.TabIndex = 42;
            // 
            // textSearchVoterName
            // 
            this.textSearchVoterName.Location = new System.Drawing.Point(117, 36);
            this.textSearchVoterName.Name = "textSearchVoterName";
            this.textSearchVoterName.Size = new System.Drawing.Size(299, 20);
            this.textSearchVoterName.TabIndex = 8;
            // 
            // comboSearchWardNo
            // 
            this.comboSearchWardNo.FormattingEnabled = true;
            this.comboSearchWardNo.Location = new System.Drawing.Point(117, 63);
            this.comboSearchWardNo.Name = "comboSearchWardNo";
            this.comboSearchWardNo.Size = new System.Drawing.Size(299, 21);
            this.comboSearchWardNo.TabIndex = 7;
            this.comboSearchWardNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Area";
            this.label1.Visible = false;
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
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Voter Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textRoomNo);
            this.panel3.Location = new System.Drawing.Point(397, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 47);
            this.panel3.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Room No.";
            // 
            // textRoomNo
            // 
            this.textRoomNo.BackColor = System.Drawing.Color.White;
            this.textRoomNo.Location = new System.Drawing.Point(117, 13);
            this.textRoomNo.Name = "textRoomNo";
            this.textRoomNo.ReadOnly = true;
            this.textRoomNo.Size = new System.Drawing.Size(81, 20);
            this.textRoomNo.TabIndex = 5;
            this.textRoomNo.TabStop = false;
            // 
            // FormSearchVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 499);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dgvVoterDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearchVoter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchVoter";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoterDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dgvVoterDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVoterName;
        private System.Windows.Forms.DataGridViewImageColumn dgcVoterPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textVoterId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboWardNo;
        private System.Windows.Forms.TextBox textVoterName;
        private System.Windows.Forms.TextBox textContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textSearchVoterName;
        private System.Windows.Forms.ComboBox comboSearchWardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textRoomNo;
    }
}

namespace VotingSoftware
{
    partial class FormVoterDetails
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.panelDataImage = new System.Windows.Forms.Panel();
            this.buttonDataImage = new System.Windows.Forms.Button();
            this.buttonHideImageDataPanel = new System.Windows.Forms.Button();
            this.buttonDataCamera = new System.Windows.Forms.Button();
            this.dgvCandidateDetails = new System.Windows.Forms.DataGridView();
            this.dgcVoterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxVoterImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textVoterId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboWardNo = new System.Windows.Forms.ComboBox();
            this.textVoterName = new System.Windows.Forms.TextBox();
            this.textContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textSearchVoterName = new System.Windows.Forms.TextBox();
            this.buttonRemoveSymbol = new System.Windows.Forms.Button();
            this.buttonEditSymbol = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelDataImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoterImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(744, 39);
            this.panelTop.TabIndex = 26;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(744, 39);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Voter Details";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataImage
            // 
            this.panelDataImage.BackColor = System.Drawing.Color.Transparent;
            this.panelDataImage.Controls.Add(this.buttonDataImage);
            this.panelDataImage.Controls.Add(this.buttonHideImageDataPanel);
            this.panelDataImage.Controls.Add(this.buttonDataCamera);
            this.panelDataImage.Location = new System.Drawing.Point(374, 256);
            this.panelDataImage.Name = "panelDataImage";
            this.panelDataImage.Size = new System.Drawing.Size(205, 115);
            this.panelDataImage.TabIndex = 150;
            // 
            // buttonDataImage
            // 
            this.buttonDataImage.BackColor = System.Drawing.Color.Black;
            this.buttonDataImage.BackgroundImage = global::VotingSoftware.Properties.Resources.p1;
            this.buttonDataImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDataImage.Location = new System.Drawing.Point(101, 37);
            this.buttonDataImage.Name = "buttonDataImage";
            this.buttonDataImage.Size = new System.Drawing.Size(97, 73);
            this.buttonDataImage.TabIndex = 6;
            this.buttonDataImage.TabStop = false;
            this.buttonDataImage.UseVisualStyleBackColor = false;
            // 
            // buttonHideImageDataPanel
            // 
            this.buttonHideImageDataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHideImageDataPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHideImageDataPanel.Location = new System.Drawing.Point(101, 3);
            this.buttonHideImageDataPanel.Name = "buttonHideImageDataPanel";
            this.buttonHideImageDataPanel.Size = new System.Drawing.Size(97, 29);
            this.buttonHideImageDataPanel.TabIndex = 7;
            this.buttonHideImageDataPanel.TabStop = false;
            this.buttonHideImageDataPanel.Text = "Hide";
            this.buttonHideImageDataPanel.UseVisualStyleBackColor = true;
            // 
            // buttonDataCamera
            // 
            this.buttonDataCamera.BackgroundImage = global::VotingSoftware.Properties.Resources.c8;
            this.buttonDataCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDataCamera.Location = new System.Drawing.Point(3, 37);
            this.buttonDataCamera.Name = "buttonDataCamera";
            this.buttonDataCamera.Size = new System.Drawing.Size(97, 73);
            this.buttonDataCamera.TabIndex = 5;
            this.buttonDataCamera.TabStop = false;
            this.buttonDataCamera.UseVisualStyleBackColor = true;
            // 
            // dgvCandidateDetails
            // 
            this.dgvCandidateDetails.AllowUserToAddRows = false;
            this.dgvCandidateDetails.AllowUserToDeleteRows = false;
            this.dgvCandidateDetails.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCandidateDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCandidateDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidateDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidateDetails.ColumnHeadersHeight = 28;
            this.dgvCandidateDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCandidateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcVoterName});
            this.dgvCandidateDetails.EnableHeadersVisualStyles = false;
            this.dgvCandidateDetails.Location = new System.Drawing.Point(13, 125);
            this.dgvCandidateDetails.MultiSelect = false;
            this.dgvCandidateDetails.Name = "dgvCandidateDetails";
            this.dgvCandidateDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidateDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidateDetails.RowHeadersWidth = 35;
            this.dgvCandidateDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCandidateDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidateDetails.Size = new System.Drawing.Size(268, 304);
            this.dgvCandidateDetails.TabIndex = 147;
            // 
            // dgcVoterName
            // 
            this.dgcVoterName.DataPropertyName = "voter_name";
            this.dgcVoterName.HeaderText = "Voter Name";
            this.dgcVoterName.Name = "dgcVoterName";
            this.dgcVoterName.ReadOnly = true;
            this.dgcVoterName.Width = 200;
            // 
            // pictureBoxVoterImage
            // 
            this.pictureBoxVoterImage.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxVoterImage.Location = new System.Drawing.Point(585, 251);
            this.pictureBoxVoterImage.Name = "pictureBoxVoterImage";
            this.pictureBoxVoterImage.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxVoterImage.TabIndex = 144;
            this.pictureBoxVoterImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonEdit);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.buttonDelete);
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(291, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 39);
            this.panel3.TabIndex = 146;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(142, 8);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(61, 8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(304, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(223, 8);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(304, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(223, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textVoterId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboWardNo);
            this.panel1.Controls.Add(this.textVoterName);
            this.panel1.Controls.Add(this.textContactNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Location = new System.Drawing.Point(291, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 148);
            this.panel1.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(420, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(422, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "1";
            // 
            // textVoterId
            // 
            this.textVoterId.Location = new System.Drawing.Point(105, 11);
            this.textVoterId.Name = "textVoterId";
            this.textVoterId.Size = new System.Drawing.Size(100, 20);
            this.textVoterId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voter Id";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
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
            // 
            // textContactNo
            // 
            this.textContactNo.Location = new System.Drawing.Point(105, 89);
            this.textContactNo.Name = "textContactNo";
            this.textContactNo.Size = new System.Drawing.Size(311, 20);
            this.textContactNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact no";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(105, 63);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(311, 20);
            this.textAddress.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textSearchVoterName);
            this.panel2.Location = new System.Drawing.Point(13, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 67);
            this.panel2.TabIndex = 143;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(246, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 145;
            this.label10.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
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
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(67, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Voter Name";
            // 
            // textSearchVoterName
            // 
            this.textSearchVoterName.Location = new System.Drawing.Point(17, 33);
            this.textSearchVoterName.Name = "textSearchVoterName";
            this.textSearchVoterName.Size = new System.Drawing.Size(224, 20);
            this.textSearchVoterName.TabIndex = 3;
            // 
            // buttonRemoveSymbol
            // 
            this.buttonRemoveSymbol.Location = new System.Drawing.Point(468, 340);
            this.buttonRemoveSymbol.Name = "buttonRemoveSymbol";
            this.buttonRemoveSymbol.Size = new System.Drawing.Size(111, 23);
            this.buttonRemoveSymbol.TabIndex = 149;
            this.buttonRemoveSymbol.Text = "Remove Photo";
            this.buttonRemoveSymbol.UseVisualStyleBackColor = true;
            // 
            // buttonEditSymbol
            // 
            this.buttonEditSymbol.Location = new System.Drawing.Point(468, 316);
            this.buttonEditSymbol.Name = "buttonEditSymbol";
            this.buttonEditSymbol.Size = new System.Drawing.Size(111, 23);
            this.buttonEditSymbol.TabIndex = 148;
            this.buttonEditSymbol.Text = "Add/Edit Photo";
            this.buttonEditSymbol.UseVisualStyleBackColor = true;
            // 
            // FormVoterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 449);
            this.Controls.Add(this.panelDataImage);
            this.Controls.Add(this.dgvCandidateDetails);
            this.Controls.Add(this.pictureBoxVoterImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonRemoveSymbol);
            this.Controls.Add(this.buttonEditSymbol);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVoterDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVoterDetails";
            this.panelTop.ResumeLayout(false);
            this.panelDataImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoterImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Panel panelDataImage;
        private System.Windows.Forms.Button buttonDataImage;
        private System.Windows.Forms.Button buttonHideImageDataPanel;
        private System.Windows.Forms.Button buttonDataCamera;
        private System.Windows.Forms.DataGridView dgvCandidateDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVoterName;
        private System.Windows.Forms.PictureBox pictureBoxVoterImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textVoterId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboWardNo;
        private System.Windows.Forms.TextBox textVoterName;
        private System.Windows.Forms.TextBox textContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSearchVoterName;
        private System.Windows.Forms.Button buttonRemoveSymbol;
        private System.Windows.Forms.Button buttonEditSymbol;
    }
}
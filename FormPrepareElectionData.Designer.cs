
namespace VotingSoftware
{
    partial class FormPrepareElectionData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxElectionCenterAddress = new System.Windows.Forms.TextBox();
            this.buttonElectionCenterAddress = new System.Windows.Forms.Button();
            this.buttonExportFormat2 = new System.Windows.Forms.Button();
            this.buttonExportFormat1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.mtextVotingDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonCreateData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCreateData = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.buttonCreateNewElectionData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUpdateElectionData = new System.Windows.Forms.Button();
            this.dgcRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVotingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVoterName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcWardId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.labelHeading = new System.Windows.Forms.Label();
            this.comboWardNo = new System.Windows.Forms.ComboBox();
            this.dgvCandidateDetails = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCreateData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateDetails)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxElectionCenterAddress
            // 
            this.textBoxElectionCenterAddress.Location = new System.Drawing.Point(152, 549);
            this.textBoxElectionCenterAddress.Name = "textBoxElectionCenterAddress";
            this.textBoxElectionCenterAddress.Size = new System.Drawing.Size(335, 20);
            this.textBoxElectionCenterAddress.TabIndex = 68;
            // 
            // buttonElectionCenterAddress
            // 
            this.buttonElectionCenterAddress.Location = new System.Drawing.Point(493, 545);
            this.buttonElectionCenterAddress.Name = "buttonElectionCenterAddress";
            this.buttonElectionCenterAddress.Size = new System.Drawing.Size(131, 24);
            this.buttonElectionCenterAddress.TabIndex = 66;
            this.buttonElectionCenterAddress.Text = "Save Address";
            this.buttonElectionCenterAddress.UseVisualStyleBackColor = true;
            // 
            // buttonExportFormat2
            // 
            this.buttonExportFormat2.Location = new System.Drawing.Point(508, 66);
            this.buttonExportFormat2.Name = "buttonExportFormat2";
            this.buttonExportFormat2.Size = new System.Drawing.Size(131, 24);
            this.buttonExportFormat2.TabIndex = 65;
            this.buttonExportFormat2.Text = "Export Format 2";
            this.buttonExportFormat2.UseVisualStyleBackColor = true;
            // 
            // buttonExportFormat1
            // 
            this.buttonExportFormat1.Location = new System.Drawing.Point(507, 42);
            this.buttonExportFormat1.Name = "buttonExportFormat1";
            this.buttonExportFormat1.Size = new System.Drawing.Size(131, 24);
            this.buttonExportFormat1.TabIndex = 64;
            this.buttonExportFormat1.Text = "Export Format 1";
            this.buttonExportFormat1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "* Room No. is editable only for new data.";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(403, 9);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 23);
            this.buttonCancel.TabIndex = 48;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // mtextVotingDate
            // 
            this.mtextVotingDate.Location = new System.Drawing.Point(149, 11);
            this.mtextVotingDate.Mask = "00/00/0000";
            this.mtextVotingDate.Name = "mtextVotingDate";
            this.mtextVotingDate.Size = new System.Drawing.Size(100, 20);
            this.mtextVotingDate.TabIndex = 47;
            this.mtextVotingDate.ValidatingType = typeof(System.DateTime);
            // 
            // buttonCreateData
            // 
            this.buttonCreateData.Location = new System.Drawing.Point(267, 9);
            this.buttonCreateData.Name = "buttonCreateData";
            this.buttonCreateData.Size = new System.Drawing.Size(135, 23);
            this.buttonCreateData.TabIndex = 46;
            this.buttonCreateData.Text = "Create Data";
            this.buttonCreateData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enter Election Date";
            // 
            // panelCreateData
            // 
            this.panelCreateData.BackColor = System.Drawing.Color.Transparent;
            this.panelCreateData.Controls.Add(this.buttonCancel);
            this.panelCreateData.Controls.Add(this.mtextVotingDate);
            this.panelCreateData.Controls.Add(this.buttonCreateData);
            this.panelCreateData.Controls.Add(this.label1);
            this.panelCreateData.Location = new System.Drawing.Point(17, 42);
            this.panelCreateData.Name = "panelCreateData";
            this.panelCreateData.Size = new System.Drawing.Size(623, 50);
            this.panelCreateData.TabIndex = 62;
            this.panelCreateData.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Election Center Address";
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(33, 59);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(15, 14);
            this.chkFilter.TabIndex = 61;
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNewElectionData
            // 
            this.buttonCreateNewElectionData.Location = new System.Drawing.Point(209, 42);
            this.buttonCreateNewElectionData.Name = "buttonCreateNewElectionData";
            this.buttonCreateNewElectionData.Size = new System.Drawing.Size(105, 49);
            this.buttonCreateNewElectionData.TabIndex = 60;
            this.buttonCreateNewElectionData.Text = "Create New Election Data";
            this.buttonCreateNewElectionData.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Filter";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(419, 43);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 48);
            this.buttonExit.TabIndex = 57;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUpdateElectionData
            // 
            this.buttonUpdateElectionData.Location = new System.Drawing.Point(314, 42);
            this.buttonUpdateElectionData.Name = "buttonUpdateElectionData";
            this.buttonUpdateElectionData.Size = new System.Drawing.Size(105, 49);
            this.buttonUpdateElectionData.TabIndex = 56;
            this.buttonUpdateElectionData.Text = "Update Existing Election Data";
            this.buttonUpdateElectionData.UseVisualStyleBackColor = true;
            // 
            // dgcRoomNo
            // 
            this.dgcRoomNo.DataPropertyName = "room_no";
            this.dgcRoomNo.HeaderText = "Room No.";
            this.dgcRoomNo.Name = "dgcRoomNo";
            // 
            // dgvVotingDate
            // 
            this.dgvVotingDate.DataPropertyName = "voting_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvVotingDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVotingDate.HeaderText = "Date";
            this.dgvVotingDate.Name = "dgvVotingDate";
            this.dgvVotingDate.ReadOnly = true;
            // 
            // dgcVoterName
            // 
            this.dgcVoterName.DataPropertyName = "voter_id";
            this.dgcVoterName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcVoterName.HeaderText = "Voter Name";
            this.dgcVoterName.Name = "dgcVoterName";
            this.dgcVoterName.ReadOnly = true;
            this.dgcVoterName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcVoterName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcVoterName.Width = 200;
            // 
            // dgcWardId
            // 
            this.dgcWardId.DataPropertyName = "area_id";
            this.dgcWardId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcWardId.HeaderText = "Ward";
            this.dgcWardId.Name = "dgcWardId";
            this.dgcWardId.ReadOnly = true;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(656, 39);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Prepare Election Data";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboWardNo
            // 
            this.comboWardNo.FormattingEnabled = true;
            this.comboWardNo.Location = new System.Drawing.Point(84, 56);
            this.comboWardNo.Name = "comboWardNo";
            this.comboWardNo.Size = new System.Drawing.Size(119, 21);
            this.comboWardNo.TabIndex = 58;
            // 
            // dgvCandidateDetails
            // 
            this.dgvCandidateDetails.AllowUserToAddRows = false;
            this.dgvCandidateDetails.AllowUserToDeleteRows = false;
            this.dgvCandidateDetails.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCandidateDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCandidateDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidateDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidateDetails.ColumnHeadersHeight = 28;
            this.dgvCandidateDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCandidateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcWardId,
            this.dgcVoterName,
            this.dgvVotingDate,
            this.dgcRoomNo});
            this.dgvCandidateDetails.EnableHeadersVisualStyles = false;
            this.dgvCandidateDetails.Location = new System.Drawing.Point(17, 101);
            this.dgvCandidateDetails.MultiSelect = false;
            this.dgvCandidateDetails.Name = "dgvCandidateDetails";
            this.dgvCandidateDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidateDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCandidateDetails.RowHeadersWidth = 35;
            this.dgvCandidateDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCandidateDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCandidateDetails.Size = new System.Drawing.Size(623, 441);
            this.dgvCandidateDetails.TabIndex = 55;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(656, 39);
            this.panelTop.TabIndex = 54;
            // 
            // FormPrepareElectionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 578);
            this.Controls.Add(this.panelCreateData);
            this.Controls.Add(this.textBoxElectionCenterAddress);
            this.Controls.Add(this.buttonElectionCenterAddress);
            this.Controls.Add(this.buttonExportFormat2);
            this.Controls.Add(this.buttonExportFormat1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.buttonCreateNewElectionData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUpdateElectionData);
            this.Controls.Add(this.comboWardNo);
            this.Controls.Add(this.dgvCandidateDetails);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrepareElectionData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrepareElectionData";
            this.panelCreateData.ResumeLayout(false);
            this.panelCreateData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateDetails)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxElectionCenterAddress;
        private System.Windows.Forms.Button buttonElectionCenterAddress;
        private System.Windows.Forms.Button buttonExportFormat2;
        private System.Windows.Forms.Button buttonExportFormat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MaskedTextBox mtextVotingDate;
        private System.Windows.Forms.Button buttonCreateData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCreateData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Button buttonCreateNewElectionData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUpdateElectionData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVotingDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcVoterName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcWardId;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.ComboBox comboWardNo;
        private System.Windows.Forms.DataGridView dgvCandidateDetails;
        private System.Windows.Forms.Panel panelTop;
    }
}
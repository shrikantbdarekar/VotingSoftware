
namespace VotingSoftware
{
    partial class FormVotingAction
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerAutoClose = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIndividualCount = new System.Windows.Forms.Label();
            this.labelSystemCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonConfirmExit = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.dgcMySelection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVote = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcSymbol = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVoterPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcCandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(229, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "individuals.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "You have to voted for ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(224, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "individuals.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIndividualCount
            // 
            this.labelIndividualCount.BackColor = System.Drawing.Color.Transparent;
            this.labelIndividualCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndividualCount.ForeColor = System.Drawing.Color.Yellow;
            this.labelIndividualCount.Location = new System.Drawing.Point(202, 71);
            this.labelIndividualCount.Name = "labelIndividualCount";
            this.labelIndividualCount.Size = new System.Drawing.Size(30, 23);
            this.labelIndividualCount.TabIndex = 52;
            this.labelIndividualCount.Text = "0";
            this.labelIndividualCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSystemCount
            // 
            this.labelSystemCount.BackColor = System.Drawing.Color.Transparent;
            this.labelSystemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemCount.ForeColor = System.Drawing.Color.Yellow;
            this.labelSystemCount.Location = new System.Drawing.Point(192, 48);
            this.labelSystemCount.Name = "labelSystemCount";
            this.labelSystemCount.Size = new System.Drawing.Size(30, 23);
            this.labelSystemCount.TabIndex = 51;
            this.labelSystemCount.Text = "0";
            this.labelSystemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "You have to vote for ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(774, 39);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Voting";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConfirmExit
            // 
            this.buttonConfirmExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmExit.Location = new System.Drawing.Point(490, 42);
            this.buttonConfirmExit.Name = "buttonConfirmExit";
            this.buttonConfirmExit.Size = new System.Drawing.Size(264, 52);
            this.buttonConfirmExit.TabIndex = 56;
            this.buttonConfirmExit.Text = "CONFIRM VOTE";
            this.buttonConfirmExit.UseVisualStyleBackColor = true;
            this.buttonConfirmExit.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(774, 39);
            this.panelTop.TabIndex = 49;
            // 
            // dgcMySelection
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgcMySelection.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcMySelection.HeaderText = "Green";
            this.dgcMySelection.Name = "dgcMySelection";
            // 
            // dgcVote
            // 
            this.dgcVote.HeaderText = "Select";
            this.dgcVote.Name = "dgcVote";
            this.dgcVote.Text = "Select";
            this.dgcVote.ToolTipText = "Click here to complete voting process.";
            this.dgcVote.UseColumnTextForButtonValue = true;
            // 
            // dgcSymbol
            // 
            this.dgcSymbol.DataPropertyName = "candidate_symbol_thumb";
            this.dgcSymbol.HeaderText = "Symbol";
            this.dgcSymbol.Name = "dgcSymbol";
            this.dgcSymbol.ReadOnly = true;
            this.dgcSymbol.Width = 125;
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "candidate_name";
            this.dgcName.HeaderText = "Name";
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            this.dgcName.Width = 200;
            // 
            // dgcVoterPhoto
            // 
            this.dgcVoterPhoto.DataPropertyName = "candidate_photo_thumb";
            this.dgcVoterPhoto.HeaderText = "Photo";
            this.dgcVoterPhoto.Name = "dgcVoterPhoto";
            this.dgcVoterPhoto.ReadOnly = true;
            this.dgcVoterPhoto.Width = 125;
            // 
            // dgcCandidateId
            // 
            this.dgcCandidateId.DataPropertyName = "candidate_id";
            this.dgcCandidateId.HeaderText = "CandidateId";
            this.dgcCandidateId.Name = "dgcCandidateId";
            this.dgcCandidateId.ReadOnly = true;
            this.dgcCandidateId.Visible = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(679, 71);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 48;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AllowUserToResizeColumns = false;
            this.dgvCandidates.AllowUserToResizeRows = false;
            this.dgvCandidates.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvCandidates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCandidates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidates.ColumnHeadersHeight = 30;
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcCandidateId,
            this.dgcVoterPhoto,
            this.dgcName,
            this.dgcSymbol,
            this.dgcVote,
            this.dgcMySelection});
            this.dgvCandidates.EnableHeadersVisualStyles = false;
            this.dgvCandidates.Location = new System.Drawing.Point(21, 97);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCandidates.RowTemplate.Height = 130;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(733, 545);
            this.dgvCandidates.TabIndex = 47;
            // 
            // FormVotingAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 666);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIndividualCount);
            this.Controls.Add(this.labelSystemCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmExit);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.dgvCandidates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVotingAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVotingAction";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAutoClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIndividualCount;
        private System.Windows.Forms.Label labelSystemCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonConfirmExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMySelection;
        private System.Windows.Forms.DataGridViewButtonColumn dgcVote;
        private System.Windows.Forms.DataGridViewImageColumn dgcSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewImageColumn dgcVoterPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCandidateId;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridView dgvCandidates;
    }
}
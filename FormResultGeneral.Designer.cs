
namespace VotingSoftware
{
    partial class FormResultGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.dgcPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVoterPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSymbol = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcVote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTextReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidates.ColumnHeadersHeight = 30;
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPanel,
            this.dgcCandidateId,
            this.dgcVoterPhoto,
            this.dgcName,
            this.dgcSymbol,
            this.dgcVote});
            this.dgvCandidates.EnableHeadersVisualStyles = false;
            this.dgvCandidates.Location = new System.Drawing.Point(16, 78);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
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
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(724, 500);
            this.dgvCandidates.TabIndex = 40;
            // 
            // dgcPanel
            // 
            this.dgcPanel.DataPropertyName = "panel_name";
            this.dgcPanel.HeaderText = "Panel";
            this.dgcPanel.Name = "dgcPanel";
            this.dgcPanel.ReadOnly = true;
            // 
            // dgcCandidateId
            // 
            this.dgcCandidateId.DataPropertyName = "candidate_id";
            this.dgcCandidateId.HeaderText = "CandidateId";
            this.dgcCandidateId.Name = "dgcCandidateId";
            this.dgcCandidateId.ReadOnly = true;
            this.dgcCandidateId.Visible = false;
            // 
            // dgcVoterPhoto
            // 
            this.dgcVoterPhoto.DataPropertyName = "candidate_photo_thumb";
            this.dgcVoterPhoto.HeaderText = "Photo";
            this.dgcVoterPhoto.Name = "dgcVoterPhoto";
            this.dgcVoterPhoto.ReadOnly = true;
            this.dgcVoterPhoto.Width = 125;
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "candidate_name";
            this.dgcName.HeaderText = "Name";
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            this.dgcName.Width = 200;
            // 
            // dgcSymbol
            // 
            this.dgcSymbol.DataPropertyName = "candidate_symbol_thumb";
            this.dgcSymbol.HeaderText = "Symbol";
            this.dgcSymbol.Name = "dgcSymbol";
            this.dgcSymbol.ReadOnly = true;
            this.dgcSymbol.Width = 125;
            // 
            // dgcVote
            // 
            this.dgcVote.DataPropertyName = "vote_count";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgcVote.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcVote.HeaderText = "Vote Count";
            this.dgcVote.Name = "dgcVote";
            this.dgcVote.ReadOnly = true;
            this.dgcVote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcVote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcVote.ToolTipText = "Click here to complete voting process.";
            this.dgcVote.Width = 80;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::VotingSoftware.Properties.Resources.a_1;
            this.panelTop.Controls.Add(this.labelHeading);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(758, 39);
            this.panelTop.TabIndex = 38;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.White;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(758, 39);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Election Result";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(625, 49);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 23);
            this.buttonExit.TabIndex = 39;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonTextReport
            // 
            this.buttonTextReport.Location = new System.Drawing.Point(16, 49);
            this.buttonTextReport.Name = "buttonTextReport";
            this.buttonTextReport.Size = new System.Drawing.Size(115, 23);
            this.buttonTextReport.TabIndex = 41;
            this.buttonTextReport.Text = "Text Report";
            this.buttonTextReport.UseVisualStyleBackColor = true;
            // 
            // FormResultGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VotingSoftware.Properties.Resources.bk_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 593);
            this.Controls.Add(this.dgvCandidates);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonTextReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResultGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCandidateId;
        private System.Windows.Forms.DataGridViewImageColumn dgcVoterPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewImageColumn dgcSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVote;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTextReport;
    }
}
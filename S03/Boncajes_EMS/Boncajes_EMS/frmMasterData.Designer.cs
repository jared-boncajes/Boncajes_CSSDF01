namespace Boncajes_EMS
{
    partial class frmMasterData
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
            this.pnlSubtitle = new System.Windows.Forms.Panel();
            this.dgvMasterdata = new System.Windows.Forms.DataGridView();
            this.lblMasterData = new System.Windows.Forms.Label();
            this.pnlSubtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubtitle
            // 
            this.pnlSubtitle.BackColor = System.Drawing.Color.SeaShell;
            this.pnlSubtitle.Controls.Add(this.lblMasterData);
            this.pnlSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitle.Name = "pnlSubtitle";
            this.pnlSubtitle.Size = new System.Drawing.Size(613, 47);
            this.pnlSubtitle.TabIndex = 0;
            // 
            // dgvMasterdata
            // 
            this.dgvMasterdata.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvMasterdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterdata.Location = new System.Drawing.Point(0, 47);
            this.dgvMasterdata.Name = "dgvMasterdata";
            this.dgvMasterdata.Size = new System.Drawing.Size(613, 339);
            this.dgvMasterdata.TabIndex = 1;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterData.Location = new System.Drawing.Point(12, 18);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(85, 15);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.dgvMasterdata);
            this.Controls.Add(this.pnlSubtitle);
            this.Name = "frmMasterData";
            this.Text = "frmMasterData";
            this.pnlSubtitle.ResumeLayout(false);
            this.pnlSubtitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitle;
        private System.Windows.Forms.DataGridView dgvMasterdata;
        private System.Windows.Forms.Label lblMasterData;
    }
}
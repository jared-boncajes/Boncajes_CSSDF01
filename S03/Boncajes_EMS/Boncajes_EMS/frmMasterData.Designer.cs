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
            this.lblMasterData = new System.Windows.Forms.Label();
            this.dgvMasterdata = new System.Windows.Forms.DataGridView();
            this.btnEditData = new System.Windows.Forms.Button();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlSubtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubtitle
            // 
            this.pnlSubtitle.BackColor = System.Drawing.Color.SeaShell;
            this.pnlSubtitle.Controls.Add(this.btnDelete);
            this.pnlSubtitle.Controls.Add(this.lblMasterData);
            this.pnlSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitle.Name = "pnlSubtitle";
            this.pnlSubtitle.Size = new System.Drawing.Size(613, 47);
            this.pnlSubtitle.TabIndex = 0;
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
            // dgvMasterdata
            // 
            this.dgvMasterdata.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvMasterdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterdata.Location = new System.Drawing.Point(0, 47);
            this.dgvMasterdata.Name = "dgvMasterdata";
            this.dgvMasterdata.Size = new System.Drawing.Size(613, 289);
            this.dgvMasterdata.TabIndex = 1;
            this.dgvMasterdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasterdata_CellClick);
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.Location = new System.Drawing.Point(504, 351);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(96, 24);
            this.btnEditData.TabIndex = 2;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Location = new System.Drawing.Point(22, 357);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(146, 13);
            this.lblTransactionNo.TabIndex = 3;
            this.lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.lblTransactionNo);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.dgvMasterdata);
            this.Controls.Add(this.pnlSubtitle);
            this.Name = "frmMasterData";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Text = "frmMasterData";
            this.Load += new System.EventHandler(this.frmMasterData_Load);
            this.pnlSubtitle.ResumeLayout(false);
            this.pnlSubtitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitle;
        private System.Windows.Forms.DataGridView dgvMasterdata;
        private System.Windows.Forms.Label lblMasterData;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Label lblTransactionNo;
        private System.Windows.Forms.Button btnDelete;
    }
}
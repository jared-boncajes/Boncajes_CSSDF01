namespace Boncajes_EMS
{
    partial class frmAddEmployee
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
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.gbEmployeeInput = new System.Windows.Forms.GroupBox();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.tbLocalNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbRequestorName = new System.Windows.Forms.TextBox();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblLocalNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblRequestorName = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.pnlSubtitle.SuspendLayout();
            this.gbEmployeeInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubtitle
            // 
            this.pnlSubtitle.BackColor = System.Drawing.Color.SeaShell;
            this.pnlSubtitle.Controls.Add(this.lblAddEmployee);
            this.pnlSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitle.Name = "pnlSubtitle";
            this.pnlSubtitle.Size = new System.Drawing.Size(613, 58);
            this.pnlSubtitle.TabIndex = 0;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 22);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(98, 15);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // gbEmployeeInput
            // 
            this.gbEmployeeInput.BackColor = System.Drawing.Color.PeachPuff;
            this.gbEmployeeInput.Controls.Add(this.btnInsertUpdate);
            this.gbEmployeeInput.Controls.Add(this.cmbSection);
            this.gbEmployeeInput.Controls.Add(this.tbLocalNumber);
            this.gbEmployeeInput.Controls.Add(this.tbEmailAddress);
            this.gbEmployeeInput.Controls.Add(this.tbRequestorName);
            this.gbEmployeeInput.Controls.Add(this.tbEmployeeNumber);
            this.gbEmployeeInput.Controls.Add(this.lblSection);
            this.gbEmployeeInput.Controls.Add(this.lblLocalNumber);
            this.gbEmployeeInput.Controls.Add(this.lblEmailAddress);
            this.gbEmployeeInput.Controls.Add(this.lblRequestorName);
            this.gbEmployeeInput.Controls.Add(this.lblEmployeeNumber);
            this.gbEmployeeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEmployeeInput.Location = new System.Drawing.Point(0, 58);
            this.gbEmployeeInput.Name = "gbEmployeeInput";
            this.gbEmployeeInput.Size = new System.Drawing.Size(613, 225);
            this.gbEmployeeInput.TabIndex = 1;
            this.gbEmployeeInput.TabStop = false;
            this.gbEmployeeInput.Text = "Employee Details Manual Insert and Update:";
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.BackColor = System.Drawing.Color.SeaShell;
            this.btnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertUpdate.Location = new System.Drawing.Point(114, 181);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(166, 28);
            this.btnInsertUpdate.TabIndex = 11;
            this.btnInsertUpdate.Text = "INSERT/UPDATE";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "BPS",
            "IT",
            "HR",
            "GA",
            "Printer",
            "Tape"});
            this.cmbSection.Location = new System.Drawing.Point(114, 154);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(216, 21);
            this.cmbSection.TabIndex = 10;
            // 
            // tbLocalNumber
            // 
            this.tbLocalNumber.BackColor = System.Drawing.Color.Snow;
            this.tbLocalNumber.Location = new System.Drawing.Point(114, 122);
            this.tbLocalNumber.Name = "tbLocalNumber";
            this.tbLocalNumber.Size = new System.Drawing.Size(216, 20);
            this.tbLocalNumber.TabIndex = 9;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.BackColor = System.Drawing.Color.Snow;
            this.tbEmailAddress.Location = new System.Drawing.Point(114, 88);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(424, 20);
            this.tbEmailAddress.TabIndex = 8;
            // 
            // tbRequestorName
            // 
            this.tbRequestorName.BackColor = System.Drawing.Color.Snow;
            this.tbRequestorName.Location = new System.Drawing.Point(114, 56);
            this.tbRequestorName.Name = "tbRequestorName";
            this.tbRequestorName.Size = new System.Drawing.Size(424, 20);
            this.tbRequestorName.TabIndex = 7;
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.BackColor = System.Drawing.Color.PeachPuff;
            this.tbEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmployeeNumber.Location = new System.Drawing.Point(114, 28);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(216, 20);
            this.tbEmployeeNumber.TabIndex = 6;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(62, 157);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(46, 13);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "Section:";
            // 
            // lblLocalNumber
            // 
            this.lblLocalNumber.AutoSize = true;
            this.lblLocalNumber.Location = new System.Drawing.Point(32, 125);
            this.lblLocalNumber.Name = "lblLocalNumber";
            this.lblLocalNumber.Size = new System.Drawing.Size(76, 13);
            this.lblLocalNumber.TabIndex = 4;
            this.lblLocalNumber.Text = "Local Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(32, 91);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 3;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblRequestorName
            // 
            this.lblRequestorName.AutoSize = true;
            this.lblRequestorName.Location = new System.Drawing.Point(18, 59);
            this.lblRequestorName.Name = "lblRequestorName";
            this.lblRequestorName.Size = new System.Drawing.Size(90, 13);
            this.lblRequestorName.TabIndex = 2;
            this.lblRequestorName.Text = "Requestor Name:";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(12, 31);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(96, 13);
            this.lblEmployeeNumber.TabIndex = 1;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.gbEmployeeInput);
            this.Controls.Add(this.pnlSubtitle);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddEmployee_FormClosed);
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.pnlSubtitle.ResumeLayout(false);
            this.pnlSubtitle.PerformLayout();
            this.gbEmployeeInput.ResumeLayout(false);
            this.gbEmployeeInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitle;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.GroupBox gbEmployeeInput;
        private System.Windows.Forms.Label lblRequestorName;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblLocalNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.TextBox tbLocalNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbRequestorName;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.Button btnInsertUpdate;
    }
}
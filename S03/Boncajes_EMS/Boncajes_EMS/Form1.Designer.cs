namespace Boncajes_EMS
{
    partial class Form1
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlSidemenu = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnMasterData = new System.Windows.Forms.Button();
            this.pnlStage = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
=======
>>>>>>> 1c39dc561bde2f812d4e686ac43365f21173e9de
            this.pnlTitleBar.SuspendLayout();
            this.pnlSidemenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblSystemName);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1104, 89);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimize
<<<<<<< HEAD
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(708, 24);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 22);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "━";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(746, 24);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 22);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "🗖";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(784, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(12, 24);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(304, 24);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Employee Management System";
            // 
            // pnlSidemenu
            // 
            this.pnlSidemenu.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlSidemenu.Controls.Add(this.btnAddEmployee);
            this.pnlSidemenu.Controls.Add(this.btnMasterData);
            this.pnlSidemenu.Controls.Add(this.panel1);
            this.pnlSidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidemenu.Location = new System.Drawing.Point(0, 72);
            this.pnlSidemenu.Name = "pnlSidemenu";
            this.pnlSidemenu.Size = new System.Drawing.Size(199, 425);
=======
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(944, 30);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 27);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "━";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(995, 30);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(43, 27);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "🗖";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1045, 30);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(16, 30);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(379, 29);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "Employee Management System";
            // 
            // pnlSidemenu
            // 
            this.pnlSidemenu.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlSidemenu.Controls.Add(this.btnAddEmployee);
            this.pnlSidemenu.Controls.Add(this.btnMasterData);
            this.pnlSidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidemenu.Location = new System.Drawing.Point(0, 89);
            this.pnlSidemenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidemenu.Name = "pnlSidemenu";
            this.pnlSidemenu.Size = new System.Drawing.Size(265, 523);
>>>>>>> 1c39dc561bde2f812d4e686ac43365f21173e9de
            this.pnlSidemenu.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Bisque;
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddEmployee.FlatAppearance.BorderSize = 2;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 158);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(199, 43);
=======
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 53);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(265, 53);
>>>>>>> 1c39dc561bde2f812d4e686ac43365f21173e9de
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnMasterData
            // 
            this.btnMasterData.BackColor = System.Drawing.Color.Bisque;
            this.btnMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMasterData.FlatAppearance.BorderSize = 2;
            this.btnMasterData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnMasterData.Location = new System.Drawing.Point(0, 115);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Size = new System.Drawing.Size(199, 43);
=======
            this.btnMasterData.Location = new System.Drawing.Point(0, 0);
            this.btnMasterData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Size = new System.Drawing.Size(265, 53);
>>>>>>> 1c39dc561bde2f812d4e686ac43365f21173e9de
            this.btnMasterData.TabIndex = 3;
            this.btnMasterData.Text = "Master Data";
            this.btnMasterData.UseVisualStyleBackColor = false;
            this.btnMasterData.Click += new System.EventHandler(this.btnMasterData_Click);
            // 
            // pnlStage
            // 
            this.pnlStage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlStage.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.pnlStage.Location = new System.Drawing.Point(199, 72);
            this.pnlStage.Name = "pnlStage";
            this.pnlStage.Size = new System.Drawing.Size(629, 425);
            this.pnlStage.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 115);
            this.panel1.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(12, 23);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(55, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "label1";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(13, 52);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(45, 16);
            this.lblSection.TabIndex = 1;
            this.lblSection.Text = "label1";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(13, 68);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "label1";
=======
            this.pnlStage.Location = new System.Drawing.Point(265, 89);
            this.pnlStage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStage.Name = "pnlStage";
            this.pnlStage.Size = new System.Drawing.Size(839, 523);
            this.pnlStage.TabIndex = 2;
>>>>>>> 1c39dc561bde2f812d4e686ac43365f21173e9de
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 612);
            this.Controls.Add(this.pnlStage);
            this.Controls.Add(this.pnlSidemenu);
            this.Controls.Add(this.pnlTitleBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlSidemenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlSidemenu;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Panel pnlStage;
        private System.Windows.Forms.Button btnMasterData;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSection;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boncajes_EMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox=false;
            this.DoubleBuffered=true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState= FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMasterData());
        }

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildform;

        private void OpenChildForm(Form childform)
        {
            if (currentChildform != null)
            {
                currentChildform.Close();
            }
            currentChildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childform);
            pnlStage.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddEmployee());
        }
    }
}

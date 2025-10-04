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
        //Dito gumagana yung nasa Common na Class. Kapag Hinold mo yung Left Click sa Top Panel, pede mo idrag ang window
        {
            if(e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e) 
        //Inedit dito kung paano ididisplay ang Form pagka-Open sa program
        {
<<<<<<< HEAD
    
            lblFullName.Text = LoginPage.fullname;
            lblSection.Text = LoginPage.Section;
            lblAge.Text = LoginPage.Age;
            this.Text = string.Empty;
            this.ControlBox=false;
            this.DoubleBuffered=true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
=======
            this.Text = string.Empty; //Tinatanggal yung title bar sa taas ng Windows Program
            this.ControlBox=false; //Tinatanggal yung Minimize, Maximize, at Close Button sa Taas.
            this.DoubleBuffered=true; //Ewan kay sir ano to
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 
            //Since nagdidisplay ng isa pang Form sa loob Ng Form ginagawa to para nagaadjust yung layout.
>>>>>>> 1c39dc561bde2f812d4e686ac43365f21173e9de
        }

        private void btnMinimize_Click(object sender, EventArgs e) //Double Click yung Ginawang Minimize button para lumabas to
           //Since tinanggal yung mismong minimize control sa taas. Gumawa ng sariling button for Minimize Window
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e) //Double Click yung Ginawang Maximize button para lumabas to
        //Since tinanggal yung mismong maximize control sa taas. Gumawa ng sariling button for Maximize Window
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState= FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) //Double Click yung Ginawang Close button para lumabas to
        //Since tinanggal yung mismong Close control sa taas. Gumawa ng sariling button for Close Window
        {
            this.Close();
        }

        private void btnMasterData_Click(object sender, EventArgs e) //Double Click yung ginawang Master Data Button
        {
            OpenChildForm(new frmMasterData()); //Inoopen yung MasterData Form sa Stage na ginawa sa Form1
        }

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildform; //NO Explanation si Sir sa tatlong to pero need

        private void OpenChildForm(Form childform) //Function na nag-aallow mag-open ng another form dun sa Blank Space sa Form1
        {
            if (currentChildform != null) //Chinecheck if may nakaopen na Form, If meron icloclose muna, If wala proceed
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

        private void btnAddEmployee_Click(object sender, EventArgs e) //Double Click yung ginawang Add Employee Button
        {
            OpenChildForm(new frmAddEmployee()); //Inoopen yung Add Employee Form
        }
    }
}

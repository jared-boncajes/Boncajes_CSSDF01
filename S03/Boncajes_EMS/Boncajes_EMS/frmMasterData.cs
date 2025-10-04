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
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dgvMasterdata, select_tblrequestorlist);
        }

        public static string EmployeeNumber, RequestorName, EmailAddress, LocalNumber, Section, ID;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete_row = $"DELETE FROM tblEmployeeData WHERE [EmployeeNumber] = '{EmployeeNumber}'";
            CRUD.CRUD.CUD(delete_row);
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dgvMasterdata, select_tblrequestorlist);
        }

        private void dgvMasterdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTransactionNo.Text = dgvMasterdata.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            EmployeeNumber = CRUD.CRUD.dt.Rows[e.RowIndex]["EmployeeNumber"].ToString();
            RequestorName = CRUD.CRUD.dt.Rows[e.RowIndex]["RequestorName"].ToString();
            EmailAddress = CRUD.CRUD.dt.Rows[e.RowIndex]["RequestorEmail"].ToString();
            LocalNumber = CRUD.CRUD.dt.Rows[e.RowIndex]["LocalNumber"].ToString();
            Section = CRUD.CRUD.dt.Rows[e.RowIndex]["Section"].ToString();
        }

        
        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (lblTransactionNo.Text == "<TRANSACTION NUMBER>")
            {
                MessageBox.Show("Must Select a Data to Update!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            frmAddEmployee edit = new frmAddEmployee(); 
            edit.Show();
            
        }
    }
}

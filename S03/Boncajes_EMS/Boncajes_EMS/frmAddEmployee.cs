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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] where [EmployeeNumber] = '" + tbEmployeeNumber.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
            if (dtg_addrequestor == true)
            {
                MessageBox.Show("This account '" + tbRequestorName.Text + "' is already exist.", "Not found.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                tbRequestorName.Text = "";
                tbEmailAddress.Text = "";
                tbLocalNumber.Text = "";
                
            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) VALUES ('" + tbEmployeeNumber.Text + "','" + tbRequestorName.Text + "','" + tbEmailAddress.Text + "','" + cmbSection.Text + "', '" + tbLocalNumber.Text + "')";
                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

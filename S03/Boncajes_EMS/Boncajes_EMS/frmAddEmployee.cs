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

        private void btnInsertUpdate_Click(object sender, EventArgs e) //Hindi Explained properly ni sir ginagawa ng bawat code here
            //Ang general Premise neto. Kapag nag Add EMployee ka sa Add Employee Form ilalagay nya sa Database yung Data
        {
            if (tbEmailAddress.Text.Contains("@firstasia.edu.ph") == true)
            {
                bool dtg_addrequestor = false;
                string EMS_data = string.Empty;
                EMS_data = "Select * from [tblEmployeeData] where [EmployeeNumber] = '" + tbEmployeeNumber.Text + "'";
                dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
                if (dtg_addrequestor == true)
                {
                    DialogResult result = MessageBox.Show("This account '" + tbRequestorName.Text + "' is already exist.", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.Yes)
                    {
                        string update_requestor = "UPDATE [tblEmployeeData] " +
                             "SET [RequestorName] = '" + tbRequestorName.Text + "', " +
                             "[RequestorEmail] = '" + tbEmailAddress.Text + "', " +
                             "[Section] = '" + cmbSection.Text + "', " +
                             "[LocalNumber] = '" + tbLocalNumber.Text + "' " +
                             "WHERE [EmployeeNumber] = '" + tbEmployeeNumber.Text + "'";

                        CRUD.CRUD.CUD(update_requestor);

                        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMasterData.EmployeeNumber = "";
                        frmMasterData.EmailAddress = "";
                        frmMasterData.LocalNumber = "";
                        frmMasterData.RequestorName = "";
                        frmMasterData.Section = "";
                        tbRequestorName.Text = "";
                        tbEmailAddress.Text = "";
                        tbLocalNumber.Text = "";
                        this.Close();
                    }
                    else
                    {
                        frmMasterData.EmployeeNumber = "";
                        frmMasterData.EmailAddress = "";
                        frmMasterData.LocalNumber = "";
                        frmMasterData.RequestorName = "";
                        frmMasterData.Section = "";
                        tbRequestorName.Text = "";
                        tbEmailAddress.Text = "";
                        tbLocalNumber.Text = "";
                        this.Close();
                    }

                }
                else
                {
                    string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName],[RequestorEmail],[Section],[LocalNumber]) values ('" + tbEmployeeNumber.Text + "','" + tbRequestorName.Text + "','" + tbEmailAddress.Text + "','" + cmbSection.Text + "', '" + tbLocalNumber.Text + "')";
                    CRUD.CRUD.CUD(add_requestor);
                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please check the email format", "Invalid Email", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
          tbEmployeeNumber.Text = frmMasterData.EmployeeNumber;
          tbRequestorName.Text = frmMasterData.RequestorName;
          tbEmailAddress.Text = frmMasterData.EmailAddress;
          tbLocalNumber.Text = frmMasterData.LocalNumber;
          cmbSection.Text = frmMasterData.Section;
        }

        private void frmAddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMasterData.EmployeeNumber = "";
            frmMasterData.EmailAddress = "";
            frmMasterData.LocalNumber = "";
            frmMasterData.RequestorName = "";
            frmMasterData.Section = "";
            tbRequestorName.Text = "";
            tbEmailAddress.Text = "";
            tbLocalNumber.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeSharingSystem.LoginPage
{
    public partial class _frmCustomerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BLL b = new BLL();

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/Customers/image/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string gen=ddlGender.SelectedItem.Text;
            if (b.checkUsrName(txtName.Text))
            {
                Label2.Visible = true;
                Label2.Text = "Name Exist.";
            }
            else
            {
                Label2.Visible = false;
                bool res = b.AddCustomers(txtName.Text, gen, txtAddress.Text, txtContactNo.Text, txtEmail.Text, txtDlNo.Text, txtPassword.Text, path);
                if (res == true)
                {
                    reset();
                    Label1.Text = "Customer Details Added Sucessfully.";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    reset();
                    Label1.Text = "Error in Adding Customer Details.";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        void reset()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            txtDlNo.Text = "";
            txtPassword.Text = "";
            ddlGender.SelectedIndex = 0;
        }
    }
}
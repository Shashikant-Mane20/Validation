using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                lblDisplay.Text = "Data is Valid";
            }
            else
            {
                lblDisplay.Text = "Data is not Valid";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtAge.Text="";
            txtConfirm.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            lblDisplay.Text = "";
        }
    }
}
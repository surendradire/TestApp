using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTest.accounts
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(TextBox1.Text.ToString(), TextBox2.Text.ToString()) == 0)
            {
                Response.Redirect("page2.aspx");
            } else
            {
                ErrorLabel.Visible = true;
            }
         
        }
    }
}
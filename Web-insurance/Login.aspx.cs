using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_insurance
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, System.EventArgs e)
        {
            MydataDataContext data = new MydataDataContext();
            var pass = from r in data.login
                       where r.username == username.Text
                       select r;
           if (pass.FirstOrDefault().password == password.Text)
            {
                Session["name"] = username.Text;
                Session["number"] = pass.FirstOrDefault().number;
                string url = "Home/index";
                Response.Redirect(url);
            }
           
        }
    }
}
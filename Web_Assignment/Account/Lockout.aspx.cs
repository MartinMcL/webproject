using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Assignment.Account
{
    public partial class Lockout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Request.IsSecureConnection)
            {
                string url =
                ConfigurationManager.AppSettings["SecurePath"] +
                "Account/Lockout.aspx";
                Response.Redirect(url);
            }
        }
    }
}
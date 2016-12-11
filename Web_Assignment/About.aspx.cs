using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Assignment
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Request.IsSecureConnection) //Redirect to https if not already
            {
                string url =
                ConfigurationManager.AppSettings["SecurePath"] +
                "/About.aspx";
                Response.Redirect(url);
            }
        }
    }
}
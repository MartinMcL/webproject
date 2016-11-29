using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Assignment.Models;

namespace Web_Assignment
{
    public partial class UserAccountPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetFavSport()
        {
            string username = Context.User.Identity.GetUserName();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var query = (from u in db.User
                             where u.email == username
                             join sp in db.Sports on u.SportID equals sp.ID
                             select sp.sportName).ToList();
                if (query[0] == "")
                {
                    return "";
                }
                else
                {
                    return query[0];
                }
            }

        }
    }
}
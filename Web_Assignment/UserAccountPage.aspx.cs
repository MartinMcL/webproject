using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        protected void yourUpComing()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //var currentUser = Convert.ToString (HttpContext.Current.User.Identity.Name);

            var favSport = from s in db.Sports
                           join u in db.User on s.ID equals u.SportID
                           //where u.email = currentUser 
                           select u.SportID;

            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var theResponse = myRequest.GetResponse())
            {
               var dataStream = theResponse.GetResponseStream();
               StreamReader reader = new StreamReader(dataStream);
               object objResponse = reader.ReadToEnd();
               var myEvents = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
               upcoming1.Text = myEvents[0].name;
               upcoming2.Text = myEvents[1].name;
               dataStream.Close();
               theResponse.Close();
            }
            
        }
        public class Event
        {
            public string id { get; set; }
            public string userId { get; set; }
            public string discipline { get; set; }
            public string name { get; set; }
            public string full_name { get; set; }
            public string status { get; set; }
            public string date_start { get; set; }
            public string date_end { get; set; }
            public bool online { get; set; }
            public bool ispublic { get; set; }
            public string location { get; set; }
            public string country { get; set; }
            public int size { get; set; }

        }
    }
}
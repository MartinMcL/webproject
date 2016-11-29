using Microsoft.AspNet.Identity;
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
            yourUpComing();
            yourNearby();
        }

        public string SportName(Sport fs)
        {
            return fs.sportName;
        }

        public Sport yourFavSport()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var currentUser = Convert.ToString(Context.User.Identity.GetUserName());

            Sport favSport = (from s in db.Sports
                              join u in db.User on s.ID equals u.SportID
                              where u.email == currentUser
                              select s).FirstOrDefault();

            return favSport;
        }

        public Location getLocation()
        {
            var myRequest =
            WebRequest.CreateHttp("http://ip-api.com/json/?fields=country,countryCode");
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            Location myLocation = new Location();
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                myLocation = JsonConvert.DeserializeObject<Location>(objResponse.ToString());
                dataStream.Close();
                theResponse.Close();
            }
            return myLocation;
        }

        public string countryName(Location loc) { return loc.country; }

        public void yourUpComing()
        {
            Sport favSport = yourFavSport();
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "&discipline=" + favSport.APISportID);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                List<Event> myEvents = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                if (myEvents.Count > 0)
                {
                    upcoming1.Text = myEvents[0].name;
                }
                dataStream.Close();
                theResponse.Close();
            }

        }
        public void yourNearby()
        {
            Location myLocation = getLocation();
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "&country=" + myLocation.countryCode);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                List<Event> myEvents = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                if (myEvents.Count > 0)
                {
                    nearby1.Text = myEvents[0].ToString();
                }
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
        public class Location
        {
            public string status { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
        }
    }
}
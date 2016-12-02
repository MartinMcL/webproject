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
    public partial class ArticlePage : System.Web.UI.Page
    {
        public string eventName;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != null )
            {
                eventName  = Request.QueryString["name"];
            }

            eventTitle.InnerText = eventName.ToString();

            string eventID;
            var requestForID =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?name=" + eventName );
            requestForID.Method = "GET";
            requestForID.UserAgent = "WebRequestDemo";
            requestForID.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var theResponse = requestForID.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var getID = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                eventID = getID[0].id;
                
                dataStream.Close();
                theResponse.Close();
            }

            var requestInfo =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments/" + eventID);
            requestInfo.Method = "GET";
            requestInfo.UserAgent = "WebRequestDemo";
            requestInfo.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var Response = requestInfo.GetResponse())
            {
                var ds = Response.GetResponseStream();
                StreamReader reader = new StreamReader(ds);
                object objRes = reader.ReadToEnd();
                var theEvent = JsonConvert.DeserializeObject<Event>(objRes.ToString());

                //string gameID = theEvent.discipline;
                //ApplicationDbContext db = new ApplicationDbContext();                 tried to fix the name whens its displayed, its displaying ID atm 
                //var getName = from s in db.Sports 
                //              where s.APISportID == gameID
                //              select s.sportName;

                eventDes.InnerText = theEvent.description;
                fullName.InnerText = theEvent.full_name;
                //gameName.Text = getName.ToString();
                gameName.Text = theEvent.discipline;
                startDate.Text = theEvent.date_start + "- " + theEvent.date_end;
                location.Text = theEvent.country + ", " + theEvent.location;
                prize.Text = theEvent.prize;

                ds.Close();
                Response.Close();
            }
        }

    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Assignment.Models;

namespace Web_Assignment
{

    //Article page was done by Dylan Murray (s00156252)

    public partial class ArticlePage : System.Web.UI.Page
    {
        public string eventName;

        protected void Page_Load(object sender, EventArgs e)
        {
            //redirect the user to https if not already  -- Security was done by Martin McLaughlin (s00151834)

            if (!Request.IsSecureConnection)
            {
                string url =
                ConfigurationManager.AppSettings["SecurePath"] +    
                "/ArticlePage.aspx";
                Response.Redirect(url);
            }
            if (Request.QueryString["name"] != null)  //Gets event name from query string so it can be used for api call 
            {
                eventName = Request.QueryString["name"];
                Page.Title = eventName;
            }

            eventTitle.InnerText = eventName.ToString();
            //API calls for ther article information from the tournament name in the query string
            var requestForID =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?name=" + eventName);
            requestForID.Method = "GET";
            requestForID.UserAgent = "WebRequestDemo";
            requestForID.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
            string eventID = "";
            using (var theResponse = requestForID.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var getID = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                if (getID.Count > 0)
                {
                    eventID = getID[0].id;   //gets id of the event to be used in a second call so that we can get more info about the event
                }
                else
                {
                    eventID = "";
                }
                dataStream.Close();
                theResponse.Close();
            }
            if (eventID != "")
            {

                var requestInfo =
                WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments/" + eventID);
                requestInfo.Method = "GET";
                requestInfo.UserAgent = "WebRequestDemo";
                requestInfo.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
                using (var Response = requestInfo.GetResponse())
                {
                    var ds = Response.GetResponseStream();
                    StreamReader reader = new StreamReader(ds);
                    object objRes = reader.ReadToEnd();
                    var theEvent = JsonConvert.DeserializeObject<Event>(objRes.ToString());

                    var gameID = theEvent.discipline;

                    ApplicationDbContext db = new ApplicationDbContext();  //gets the full name of the event to be displayed instead of the sport ID
                    var getName = (string)(from s in db.Sports
                                           where s.APISportID == gameID
                                           select s.sportName).FirstOrDefault();

                    eventDes.InnerText = theEvent.description == null || theEvent.description.Length < 2 ? "No description for this event!" : theEvent.description;
                    fullName.InnerText = theEvent.full_name;
                    gameName.Text = getName;
                    startDate.Text = theEvent.date_start + "  until  " + theEvent.date_end;
                    location.Text = (theEvent.country + ", " + theEvent.location).ToString().Length < 4 || theEvent.location == null || theEvent.country == null ? "Unknown" : (theEvent.country + ", " + theEvent.location);
                    prize.Text = theEvent.prize == null || theEvent.prize.ToString().Length < 2 ? "Unknown" : theEvent.prize;
                    ds.Close();
                    Response.Close();
                }
            }
        }

    }
}
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
            randomEvent();
            latestResults();
        }

        public string SportName(Sport fs)
        {
            if (fs != null)
            {
                return fs.sportName;
            }
            else
            {
                return "";
            }
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
            if (favSport != null)
            {

                var myRequest = WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + (DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "&discipline=" + favSport.APISportID);
                myRequest.Method = "GET";
                myRequest.UserAgent = "WebRequestDemo";
                myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
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


        }

        public void latestResults()
        {
            Sport favSport = yourFavSport();
            if (favSport != null)
            {
                var myRequest = WebRequest.CreateHttp("https://api.toornament.com/v1/disciplines/" + favSport.APISportID + "/matches?has_result=1&before_date=" + DateTime.Now.Year + "-" + (DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "&sort=date_desc");
                myRequest.Method = "GET";
                myRequest.UserAgent = "WebRequestDemo";
                myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
                using (var theResponse = myRequest.GetResponse())
                {
                    var dataStream = theResponse.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    object objResponse = reader.ReadToEnd();
                    List<Result> myResults = JsonConvert.DeserializeObject<List<Result>>(objResponse.ToString());
                    if (myResults.Count > 0)
                    {
                        tbl1Tourn1.Text = myResults[0].tournament.name;
                        tbl1Team1.Text = myResults[0].opponents[0].participant.name;
                        tbl1Team1Score.Text = myResults[0].opponents[0].score.ToString();
                        tbl1Team2.Text = myResults[0].opponents[1].participant.name;
                        tbl1Team2Score.Text = myResults[0].opponents[1].score.ToString();

                        tbl2Tourn2.Text = myResults[1].tournament.name;
                        tbl2Team1.Text = myResults[1].opponents[0].participant.name;
                        tbl2Team1Score.Text = myResults[1].opponents[0].score.ToString();
                        tbl2Team2.Text = myResults[1].opponents[1].participant.name;
                        tbl2Team2Score.Text = myResults[1].opponents[1].score.ToString();

                        tbl3Tourn3.Text = myResults[2].tournament.name;
                        tbl3Team1.Text = myResults[2].opponents[0].participant.name;
                        tbl3Team1Score.Text = myResults[2].opponents[0].score.ToString();
                        tbl3Team2.Text = myResults[2].opponents[1].participant.name;
                        tbl3Team2Score.Text = myResults[2].opponents[1].score.ToString();

                        tbl4Tourn4.Text = myResults[3].tournament.name;
                        tbl4Team1.Text = myResults[3].opponents[0].participant.name;
                        tbl4Team1Score.Text = myResults[3].opponents[0].score.ToString();
                        tbl4Team2.Text = myResults[3].opponents[1].participant.name;
                        tbl4Team2Score.Text = myResults[3].opponents[1].score.ToString();

                    }
                    dataStream.Close();
                    theResponse.Close();
                }
            }


        }
        public void yourNearby()
        {
            Location myLocation = getLocation();
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + (DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "&country=" + myLocation.countryCode);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                List<Event> myEvents = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                if (myEvents.Count > 0)
                {
                    nearby1.Text = myEvents[0].name;
                }
                dataStream.Close();
                theResponse.Close();
            }

        }

        public void randomEvent()
        {
            Location myLocation = getLocation();
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + (DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "&featured=1");
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                List<Event> myEvents = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                if (myEvents.Count > 0)
                {
                    Random rng = new Random();
                    random1.Text = myEvents[rng.Next(0, myEvents.Count)].name;
                }
                dataStream.Close();
                theResponse.Close();
            }

        }

        public class Location
        {
            public string status { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
        }


        public class Tournament
        {
            public string id { get; set; }
            public string name { get; set; }
            public object full_name { get; set; }
            public bool featured { get; set; }
        }

        public class Participant
        {
            public string id { get; set; }
            public string name { get; set; }
            public string country { get; set; }
        }

        public class Opponent
        {
            public Participant participant { get; set; }
            public bool forfeit { get; set; }
            public string number { get; set; }
            public string result { get; set; }
            public string score { get; set; }
        }

        public class Result
        {
            public string id { get; set; }
            public string status { get; set; }
            public object date { get; set; }
            public object timezone { get; set; }
            public string match_format { get; set; }
            public string type { get; set; }
            public string discipline { get; set; }
            public Tournament tournament { get; set; }
            public List<Opponent> opponents { get; set; }
        }
    }
}
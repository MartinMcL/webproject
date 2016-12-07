using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Web_Assignment.Models;

namespace Web_Assignment
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTrending();
            GetUpcoming();
            GetLatest();
        }
        public void GetUpcoming()
        {
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?after_start=" + DateTime.Now.Year + "-" + (DateTime.Now.Month.ToString().Length == 1 ? "0"+DateTime.Now.Month.ToString(): DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()));
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var myEvents = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                upcoming1.Text = myEvents[0].name;
                upcoming2.Text = myEvents[1].name;
                upcoming3.Text = myEvents[2].name;
                upcoming4.Text = myEvents[3].name;
                dataStream.Close();
                theResponse.Close();
            }
        }
        public void GetLatest()
        {
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?status=completed&before_end=" + DateTime.Now.Year + "-" + (DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()));
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var latestEvent = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                latest1.Text = latestEvent[0].name;
                latest2.Text = latestEvent[1].name;
                latest3.Text = latestEvent[2].name;
                latest4.Text = latestEvent[3].name;
                dataStream.Close();
                theResponse.Close();
            }

        }

        public void GetTrending()
        {
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?featured=1");
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "Oo8MTVO7WkJ0NOwJdLNznE5FuJ-II1E5kPVxMM_R2qg");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var trendEvent = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                //trend1.Text = trendEvent[0].name;
                //trend2.Text = trendEvent[1].name;
                //trend3.Text = trendEvent[2].name;
                //trend4.Text = trendEvent[3].name;

                //1st slide
                var getName1 = trendEvent[0].discipline;
                ApplicationDbContext db = new ApplicationDbContext();
                var gameName1 = (string)(from s in db.Sports
                                       where s.APISportID == getName1
                                       select s.sportName).FirstOrDefault();
                cap0.InnerText = "Featured " + gameName1 + " event in " + trendEvent[0].location + " " + trendEvent[0].country;
                eventTitle1.InnerText = trendEvent[0].name;

                //2nd slide
                var getName2 = trendEvent[1].discipline;
                var gameName2 = (string)(from s in db.Sports
                                         where s.APISportID == getName2
                                         select s.sportName).FirstOrDefault();
                cap1.InnerText = "Featured " + gameName2 + " event in " + trendEvent[1].location + " " + trendEvent[0].country;
                eventTitle2.InnerText = trendEvent[1].name;

                //3rd slide
                var getName3 = trendEvent[2].discipline;
                var gameName3 = (string)(from s in db.Sports
                                         where s.APISportID == getName3
                                         select s.sportName).FirstOrDefault();
                cap2.InnerText = "Featured " + gameName3 + " event in " + trendEvent[2].location + " " + trendEvent[0].country;
                eventTitle3.InnerText = trendEvent[2].name;

                //4th slide
                var getName4 = trendEvent[3].discipline;
                var gameName4 = (string)(from s in db.Sports
                                         where s.APISportID == getName4
                                         select s.sportName).FirstOrDefault();
                cap3.InnerText = "Featured " + gameName4 + " event in " + trendEvent[3].location + " " + trendEvent[0].country;
                eventTitle4.InnerText = trendEvent[3].name;

                dataStream.Close();
                theResponse.Close();
            }

        }

    }
}
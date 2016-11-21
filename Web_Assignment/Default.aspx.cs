﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace Web_Assignment
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTrending();
            GetUpcoming();
            GetLatest();
            GetDisciplines();
        }

        public void GetUpcoming()
        {
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
                upcoming3.Text = myEvents[2].name;
                upcoming4.Text = myEvents[3].name;
                dataStream.Close();
                theResponse.Close();
            }
        }
        public void GetLatest()
        {
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/tournaments?status=completed&before_end=" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
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
            myRequest.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var trendEvent = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                trend1.Text = trendEvent[0].name;
                trend2.Text = trendEvent[1].name;
                trend3.Text = trendEvent[2].name;
                trend4.Text = trendEvent[3].name;
                dataStream.Close();
                theResponse.Close();
            }

        }

        public void GetDisciplines()
        {
            var myRequest =
            WebRequest.CreateHttp("https://api.toornament.com/v1/disciplines");
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo";
            myRequest.Headers.Add("X-Api-Key", "tMOO055zm0le1b3XJu_pNxl4Q1i3yZuyF04uIwwSufI");
            using (var theResponse = myRequest.GetResponse())
            {
                var dataStream = theResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                object objResponse = reader.ReadToEnd();
                var trendEvent = JsonConvert.DeserializeObject<List<Event>>(objResponse.ToString());
                trend1.Text = trendEvent[0].name;
                trend2.Text = trendEvent[1].name;
                trend3.Text = trendEvent[2].name;
                trend4.Text = trendEvent[3].name;
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
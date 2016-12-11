using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Assignment
{
    //Created by Martin and changed by Dylan

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
        public string description { get; set; }
        public string prize { get; set; }
    }
}
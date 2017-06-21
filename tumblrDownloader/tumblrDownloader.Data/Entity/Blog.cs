using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblrDownloader.Data.Entity
{
    public class Blog
    {                      
        public bool share_following { get; set; }
        public bool can_be_followed { get; set; }

        public bool ask { get; set; }
        public bool ask_anon { get; set; }
        public string ask_page_title { get; set; }
        public bool can_subscribe { get; set; }
        public string description { get; set; }
        public bool is_adult { get; set; }
        public bool is_nsfw { get; set; }
        public int likes { get; set; }
        public string name { get; set; }
        public int posts { get; set; }
        public string reply_conditions { get; set; }
        public bool share_likes { get; set; }
        public bool subscribed { get; set; }
        public string title { get; set; }
        public int total_posts { get; set; }
        public int updated { get; set; }
        public string url { get; set; }


        public bool active { get; set; }
        public Theme theme { get; set; }
    }
}

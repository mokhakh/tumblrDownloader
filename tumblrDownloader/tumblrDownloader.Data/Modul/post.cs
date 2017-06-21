using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblrDownloader.Data.Entity
{
    public class PostRootobject : Rootobject
    {
        public PostResponse response { get; set; }
    }
    
    public class PostResponse
    {
        public Blog blog { get; set; }
        public Post[] posts { get; set; }
        public int total_posts { get; set; }
    }
    

   

    

}

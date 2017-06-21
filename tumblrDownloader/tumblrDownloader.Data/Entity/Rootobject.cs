using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblrDownloader.Data.Entity
{
    public class Rootobject
    {
        public Meta meta { get; set; }        
        public Error[] errors { get; set; }
    }
}

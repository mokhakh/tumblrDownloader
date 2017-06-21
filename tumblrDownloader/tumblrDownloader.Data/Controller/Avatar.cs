using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblrDownloader.Data.Controller
{
    public class Avatar
    {
        public byte[] GetImage(string blogId)
        {
            string url = $"https://api.tumblr.com/v2/blog/{blogId}/avatar/512";
            var img = API.GetImage(url);
            return img;
        }
    }
}

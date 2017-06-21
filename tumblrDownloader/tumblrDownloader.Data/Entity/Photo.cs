using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblrDownloader.Data.Entity
{
    public class Photo
    {
        public string caption { get; set; }
        public Original_Size original_size { get; set; }
        public Alt_Sizes[] alt_sizes { get; set; }
    }

    public class Original_Size
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Alt_Sizes
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}

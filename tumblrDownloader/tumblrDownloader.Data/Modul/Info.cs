using tumblrDownloader.Data.Entity;

namespace tumblrDownloader.Data.Modul
{
    public class InfoRootobject: Rootobject
    {       
        public InfoResponse response { get; set; }        
    }

    public class InfoResponse
    {
        public Blog blog { get; set; }
    }




   

   


}

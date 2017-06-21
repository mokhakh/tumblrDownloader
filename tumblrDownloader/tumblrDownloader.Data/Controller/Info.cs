using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tumblrDownloader.Data.Entity;

namespace tumblrDownloader.Data.Controller
{
    public class Info
    {
        public string Errors { get; set; }

        public Blog GetInfo(string blogId)
        {
            string json = API.Get("info", blogId);
            if(string.IsNullOrEmpty(json))
                return null;
            var infoJson= JsonConvert.DeserializeObject<Modul.InfoRootobject>(json);
            if (infoJson != null)
            {
                if (infoJson.errors != null)
                {
                    foreach (Error error in infoJson.errors)
                    {
                        Errors += error.detail + ",";
                    }
                    Errors= Errors.TrimEnd(',');
                    return null;
                }

                return infoJson.response.blog;
            }
            return null;
        }
    }
}

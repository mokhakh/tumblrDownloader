using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace tumblrDownloader.Data
{
    public class API
    {
        private static string ApiKey {
            get { return "Lf9c39fi4hj9qJ0OYwSQxm6ewkgcqn9VBlX3OkWKVA6qxuAgXZ"; }
        }

        public static string Get(string module,string blogId)
        {            
            string url = $"https://api.tumblr.com/v2/blog/{blogId}/{module}?api_key={ApiKey}";
           
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = new TimeSpan(1, 0, 0); // 1 hour
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        string responseString = responseContent.ReadAsStringAsync().Result;                       
                        return responseString;
                    }                   
                }
            }
            catch (Exception ex)
            {
                                
            }
            return "";
        }

        public static byte[] GetImage(string url)
        {
            string fullPath = "";
            try
            {
                using (var client = new WebClient())
                {                    
                    var data = client.DownloadData(url);                    
                    return data;
                }
            }
            catch (Exception ex)
            {                
            }
            return null;
        }



    }
}

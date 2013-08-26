using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace imdbSearch
{
    public class ImdbSearch
    {
        static void Main(string[] args)
        {
        }

        public bool movieFound(string movieName)
        {
            WebClient client = new WebClient();

            string result = client.DownloadString("http://www.omdbapi.com/?i=&t=" + movieName);
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            Test routes_list =
                   (Test)json_serializer.DeserializeObject("{ \"test\":\"some data\" }");
            return false;
        }
    }
}

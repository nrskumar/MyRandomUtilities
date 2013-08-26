using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Microsoft.JScript;

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
            ImdbMovie movie = Newtonsoft.Json.JsonConvert.DeserializeObject<ImdbMovie>(result);
            if (movie.Title == null)
                return false;
            else
                return true;
        }
    }

    public class ImdbMovie
    {
        public string Title { get; set; }
        public decimal imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public long ImdbVotes { get { return long.Parse(imdbVotes, System.Globalization.NumberStyles.Any); } }
    }
}

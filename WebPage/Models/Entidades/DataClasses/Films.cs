using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Films : Default
    {

        private const string base_url = "https://swapi.dev/api/films";

        public string title { get; set; }

        public string episode_id { get; set; }

        public string opening_crawl { get; set; }

        public string director { get; set; }

        public string producer { get; set; }

        public string release_date { get; set; }

        public string[] species { get; set; }


        public string[] starships { get; set; }

        public string[] vehicles { get; set; }

        public string[] characters { get; set; }

        public string[] planets { get; set; }

        public Interfaces.SWAPI<Films> API = new Interfaces.SWAPI<Films>(base_url);


    }
}
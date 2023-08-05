using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class People : Default
    {

        private const string base_url = "https://swapi.dev/api/people";

        public string name { get; set; }

        public string birth_year { get; set; }

        public string eye_color { get; set; }

        public string gender { get; set; }

        public string hair_color { get; set; }

        public string height { get; set; }

        public string mass { get; set; }

        public string skin_color { get; set; }

        public string homeworld { get; set; }

        public string[] films { get; set; }


        public string[] species { get; set; }


        public string[] starships { get; set; }

        public string[] vehicles { get; set; }

        public Interfaces.SWAPI<People> API = new Interfaces.SWAPI<People>(base_url);

    }
}
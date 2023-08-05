using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Species : Default
    {

        private const string base_url = "https://swapi.dev/api/species";

        public string name { get; set; }

        public string classification { get; set; }

        public string designation { get; set; }

        public string average_height { get; set; }

        public string average_lifespan { get; set; }

        public string eye_colors { get; set; }

        public string hair_colors { get; set; }

        public string skin_color { get; set; }

        public string homeworld { get; set; }

        public string language { get; set; }

        public string[] films { get; set; }

        public string[] people { get; set; }

        public Interfaces.SWAPI<Species> API = new Interfaces.SWAPI<Species>(base_url);

    }
}
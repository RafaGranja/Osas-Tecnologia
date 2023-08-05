using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Entidades
{
    public class Root
    {
        public Root() { }

        public const string base_url = "https://swapi.dev/api/";

        public string films { get; set; }

        public string people { get; set; }

        public string planets { get; set; }

        public string species { get; set; }

        public string starships { get; set; }

        public string vehicles { get; set; }

        public Interfaces.SWAPI<Root> API = new Interfaces.SWAPI<Root>(base_url);

    }
}
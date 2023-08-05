using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Planets : Default
    {

        private const string base_url = "https://swapi.dev/api/planets";

        public string name { get; set; }

        public string diameter { get; set; }

        public string rotation_period { get; set; }

        public string orbital_period { get; set; }

        public string gravity { get; set; }

        public string population { get; set; }

        public string climate { get; set; }

        public string terrain { get; set; }

        public string surface_water { get; set; }

        public string[] residents { get; set; }

        public string[] films { get; set; }

        public Interfaces.SWAPI<Planets> API = new Interfaces.SWAPI<Planets>(base_url);

    }
}
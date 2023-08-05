using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades
{
    public class Vehicles : Default
    {

        private const string base_url = "https://swapi.dev/api/vehicles";

        public string name { get; set; }

        public string model { get; set; }

        public string vehicle_class { get; set; }

        public string manufacturer { get; set; }

        public string cost_in_credits { get; set; }

        public string length { get; set; }

        public string crew { get; set; }

        public string passengers { get; set; }

        public string max_atmosphering_speed { get; set; }

        public string cargo_capacity { get; set; }

        public string consumables { get; set; }

        public string[] films { get; set; }

        public string[] pilots { get; set; }

        public Interfaces.SWAPI<Vehicles> API = new Interfaces.SWAPI<Vehicles>(base_url);


    }
}
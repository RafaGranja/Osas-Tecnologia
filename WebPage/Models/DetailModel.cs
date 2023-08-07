using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using Interfaces;

namespace Models
{
    public class DetailModelFilms
    {

        public Films root;

        public List<People> characters { get; set; }

        public List<Planets> planets { get; set; }

        public List<Species> species { get; set; }

        public List<Starships> starships { get; set; }

        public List<Vehicles> vehicles { get; set; }

        public DetailModelFilms()
        {
            root = new Films();
        }

    }

    public class DetailModelPlanets
    {

        public Planets root;

        public List<Films> films { get; set; }

        public List<People> residents { get; set; }

        public DetailModelPlanets(string url)
        {
            root = new Planets();
        }

    }

    public class DetailModelPeople
    {

        public People root;

        public List<Films> films { get; set; }

        public List<Species> species { get; set; }

        public List<Starships> starships { get; set; }

        public List<Vehicles> vehicles { get; set; }

        public Planets homeworld { get; set; }

        public DetailModelPeople()
        {
            root = new People();
        }

    }

    public class DetailModelSpecies
    {

        public Species root;

        public List<Films> films { get; set; }

        public List<People> people { get; set; }

        public Planets homeworld { get; set; }

        public DetailModelSpecies()
        {
            root = new Species();
        }

    }

    public class DetailModelStarships
    {

        public Starships root;

        public List<Films> films { get; set; }

        public List<People> pilots { get; set; }

        public DetailModelStarships()
        {
            root = new Starships();
        }

    }

    public class DetailModelVehicles
    {

        public Vehicles root;

        public List<Films> films { get; set; }

        public List<People> pilots { get; set; }

        public DetailModelVehicles(string url)
        {
            root = new Vehicles();
        }

    }
}
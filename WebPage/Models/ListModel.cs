using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interfaces;
using Entidades;

namespace Models
{
    public class ListFilmsModel
    {

        public InterfacePageList<Films> root;

        public ListFilmsModel(string url)
        {
            root = new InterfacePageList<Films>(url+"/films");
        }
    }

    public class ListPeopleModel
    {

        public InterfacePageList<People> root;

        public ListPeopleModel(string url)
        {
            root = new InterfacePageList<People>(url+"/people");
        }
    }
    public class ListPlanetsModel
    {

        public InterfacePageList<Planets> root;

        public ListPlanetsModel(string url)
        {
            root = new InterfacePageList<Planets>(url+"/planets");
        }
    }
    public class ListSpeciesModel
    {

        public InterfacePageList<Species> root;

        public ListSpeciesModel(string url)
        {
            root = new InterfacePageList<Species>(url+"/species");
        }
    }
    public class ListStarshipsModel
    {

        public InterfacePageList<Starships> root;

        public ListStarshipsModel(string url)
        {
            root = new InterfacePageList<Starships>(url+"/starships");
        }
    }
    public class ListVehiclesModel
    {

        public InterfacePageList<Vehicles> root;

        public ListVehiclesModel(string url)
        {
            root = new InterfacePageList<Vehicles>(url+"/vehicles");
        }
    }

}
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Web;

namespace Interfaces
{
    public class InterfacePageList<T>
    {

        public string base_url { get; set; }

        public int count { get; set; }

        public string next { get; set; }

        public string previous { get; set; }

        public T[] results { get; set; }

        public Interfaces.SWAPI<InterfacePageList<T>> API;

        public InterfacePageList(string url)
        {

            this.base_url = url;
            this.API = new SWAPI<InterfacePageList<T>>(url);

        }

    }

}
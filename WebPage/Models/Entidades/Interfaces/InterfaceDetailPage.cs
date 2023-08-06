using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interfaces
{
    public class InterfaceDetailPage<T>
    {
        public string base_url { get; set; }

        public T root { get; set; }

        public Interfaces.SWAPI<InterfaceDetailPage<T>> API;

        public InterfaceDetailPage(string url)
        {

            this.base_url = url;
            this.API = new SWAPI<InterfaceDetailPage<T>>(url);

        }

    }
}
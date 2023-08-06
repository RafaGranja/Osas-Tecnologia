using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using Interfaces;

namespace Models
{
    public class DetailModel<T>
    {

        public InterfaceDetailPage<T> root;

        public DetailModel(string url)
        {
            root = new InterfaceDetailPage<T>(url);
        }

    }
}
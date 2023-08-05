using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interfaces
{
    public class InterfacePageList<T>
    {
            
        public int count { get; set; }

        public string next { get; set; }

        public string previous { get; set; }

        public T[] results { get; set; }

    }
}
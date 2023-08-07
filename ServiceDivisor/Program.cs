using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading;

namespace ServiceDivisor
{
    class Program:ServiceBase
    {

        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                    new Service1(args)
            };
            Run(ServicesToRun);
        }

    }
}
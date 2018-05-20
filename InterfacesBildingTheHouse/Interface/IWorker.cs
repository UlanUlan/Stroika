using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Interface
{
    interface IWorker
    {
        string Name { get; set; }
        double Salery { get; set; }

         bool IsTaem { get; set; }

        void PrintReport(List<IPart> parts);
    }
}

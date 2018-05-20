
using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    public class TeamLeader : IWorker
    {
        public bool IsTaem { get; set; } = true;

        string IWorker.Name { get; set; }

        double IWorker.Salery { get; set; }

        public void PrintReport(List<IPart> parts)
        {
            Console.WriteLine(" ");
        }
    }
}

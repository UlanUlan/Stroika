using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public bool IsTaem { get; set; } = false;

        //string IWorker.Name { get; set; }

        public double Salery { get; set; }

        public List<IPart> jobs { get; set; } = new List<IPart>();
        //double IWorker.Salery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PrintReport(List<IPart> parts)
        {

                Console.WriteLine("Name: " + Name + " | Salary " + Salery);
                if (jobs.Count > 0)
                    Console.WriteLine("Part - " + jobs[jobs.Count - 1]);
               
        }
    }
}

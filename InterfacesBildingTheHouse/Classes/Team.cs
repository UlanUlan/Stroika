
using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    public class Team
    {

        public List<Worker> Workers { get; set; } = new List<Worker>();
        private Random rand = new Random();

        public void GenerateWorkwer()
        {
            for (int i = 0; i < rand.Next(3, 10); i++)
            {
                Worker worker = new Worker();
                if (i == 0)
                {
                    worker.Name = "Ludovic" + rand.Next(1,100);
                    worker.IsTaem = true;
                }
                worker.Name = "Ludovic" + rand.Next(1,100);
                Workers.Add(worker);
            }
        }

        public void WorkJ(ref List<IPart> parts)
        {
            parts.OrderBy(o => o.Priority);
            foreach (IPart item in parts.OrderBy(o => o.Priority)) // не работает
            {
                int wNum = rand.Next(1, Workers.Count);
                if (!Workers[wNum].IsTaem)
                {
                    if (item.StartWork.Year == 1)
                    {
                        item.StartWork = DateTime.Now;
                        item.EndWork = DateTime.Now.AddDays(rand.Next(1, 30));
                    }
                    Workers[wNum].jobs.Add(item);
                    Workers[wNum].Salery = Workers[wNum].jobs.Count * 100;
                    Workers[wNum].PrintReport(parts);
                    Console.WriteLine("Start works - " + item.StartWork);
                    Console.WriteLine("End works - " + item.EndWork);
                    Console.WriteLine("----------------------------------");
                    //break;
                }
                else
                {
                    Workers[wNum].PrintReport(parts);
                }
            }
        }

    }


}



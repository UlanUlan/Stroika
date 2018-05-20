using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    public class Window : IPart
    {
        public string Colour { get; set; }
        public string Material { get; set; }
        public DateTime EndWork { get; set; }  
        public string Name { get; set; }
        public DateTime StartWork { get; set; }
        public string Manufactery { get; set; }
        public int Priority { get; set; }
    }
}

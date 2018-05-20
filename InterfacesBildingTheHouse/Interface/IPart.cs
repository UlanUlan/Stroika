using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Interface
{
    public interface IPart
    {
        string Name { get; set; }

        int Priority { get; set; }

        DateTime StartWork { get; set; }
        DateTime EndWork { get; set; }
    }
}

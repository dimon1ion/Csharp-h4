using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw4.Interfaces
{
    interface IPart
    {
        string Name { get; set; }
        bool IsInstal { get; set; }
        void Instal();
    }
}

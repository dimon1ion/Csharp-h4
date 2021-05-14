using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw4.Interfaces
{
    interface IWorker
    {
        House House { get; set; }
        void Work();
    }
}

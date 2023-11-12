using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IWorker
    {
        void Work(IPart part);
        void Work(House house);
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Worker : IWorker
    {
        public void Work(IPart part)
        {
            part.Build();
        }
    }

    public class TeamLeader : IWorker
    {
        public void Work(IPart part)
        {
            Console.WriteLine("Checking the work done...");
        }
    }

}

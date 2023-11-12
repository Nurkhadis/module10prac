using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Basement is built");
        }
    }

    public class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Wall is built");
        }
    }

    public class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Door is installed");
        }
    }

    public class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Window is installed");
        }
    }

    public class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Roof is constructed");
        }
    }

}

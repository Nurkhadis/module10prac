using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class House
    {
        private List<IPart> parts = new List<IPart>();

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }
        public void Build()
        {
            foreach (var part in parts)
            {
                part.Build();
            }
        }
        public void ShowParts()
        {
            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Team
    {
        private readonly List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void StartBuilding(House house)
        {
            Console.WriteLine("Building the house...");
            house.AddPart(new Basement());

            for (int i = 0; i < 4; i++)
            {
                house.AddPart(new Wall());
            }

            house.AddPart(new Door());

            for (int i = 0; i < 4; i++)
            {
                house.AddPart(new Window());
            }

            house.AddPart(new Roof());

            foreach (var worker in workers)
            {
                worker.Work(house);
            }
        }
    }

}

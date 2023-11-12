using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace module10prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();

            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLeader());

            team.StartBuilding(house);

            Console.WriteLine("Construction of the house is completed. Here's the final look:");
            house.Build(); // Строим сам дом
            Console.ReadKey();
        }
        
    }
}

using Csharp_hw4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dimon1ion";
            Console.ForegroundColor = ConsoleColor.White;
            House house = new House(new Basement[1] { new Basement() },
                new Wall[4] { new Wall(), new Wall(), new Wall(), new Wall() },
                new Door[1] { new Door() },
                new Window[4] { new Window(), new Window(), new Window(), new Window() },
                new Roof[1] { new Roof() } );
            Team team = new Team(house);
            for (int i = 1; i < team.Worker.Length; i++)
            {
                team[0].Work();
                team[i].Work();
            }
            bool ready = true;
            foreach (IPart item in house)
            {
                if (item.IsInstal == false)
                {
                    ready = false;
                }
            }
            if (ready)
            {
                Console.Clear();
                Console.WriteLine(
                    $" __  /\\" + '\n' +
                    $" || / _\\" + '\n' +
                    $" ||/ _ _\\" + '\n' +
                    $" |/__  _ \\" + '\n' +
                    $" /|__|  _ \\" + '\n' +
                    $"/__________\\" + '\n' +
                    $"| _ _  __  |" + '\n' +
                    $"|  _  |__| |" + '\n' +
                    $"|_  ____  _|" + '\n' +
                    $"| _ |  | _ |" + '\n' +
                    $"|___|__|___|" + '\n' +
                    $"Construction has completed");
                Console.ReadKey();
            }
        }
    }
}

using Csharp_hw4.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_hw4
{
    #region Parts

    class Basement : IPart
    {
        public bool IsInstal{ get; set; }
        public string Name { get; set; }

        public Basement()
        {
            Name = "Basement";
            IsInstal = false;
        }

        public void Instal()
        {
            Console.WriteLine("Installing Basement..");
            Thread.Sleep(1200);
            Console.WriteLine("Basement has installed.\n");
            Thread.Sleep(400);
            Console.Clear();
            IsInstal = true;
        }
    }
    class Wall : IPart
    {
        public string Name { get; set; }
        public bool IsInstal { get; set; }
        public Wall()
        {
            Name = "Wall";
            IsInstal = false;
        }

        public void Instal()
        {
            Console.WriteLine("Installing Wall..");
            Thread.Sleep(800);
            Console.WriteLine("Wall has installed.\n");
            Thread.Sleep(400);
            Console.Clear();
            IsInstal = true;
        }
    }
    class Door : IPart
    {
        public string Name { get; set; }
        public bool IsInstal { get; set; }
        public Door()
        {
            Name = "Door";
            IsInstal = false;
        }

        public void Instal()
        {
            Console.WriteLine("Installing Door..");
            Thread.Sleep(1000);
            Console.WriteLine("Door has installed.\n");
            Thread.Sleep(400);
            Console.Clear();
            IsInstal = true;
        }
    }
    class Window : IPart
    {
        public string Name { get; set; }
        public bool IsInstal { get; set; }
        public Window()
        {
            Name = "Window";
            IsInstal = false;
        }

        public void Instal()
        {
            Console.WriteLine("Installing Window..");
            Thread.Sleep(900);
            Console.WriteLine("Window has installed.\n");
            Thread.Sleep(400);
            Console.Clear();
            IsInstal = true;
        }
    }
    class Roof : IPart
    {
        public string Name { get; set; }
        public bool IsInstal { get; set; }
        public Roof()
        {
            Name = "Roof";
            IsInstal = false;
        }

        public void Instal()
        {
            Console.WriteLine("Installing Roof..");
            Thread.Sleep(1300);
            Console.WriteLine("Roof has installed.\n");
            Thread.Sleep(400);
            Console.Clear();
            IsInstal = true;
        }
    }

    #endregion
    
    class House : IEnumerable
    {
        public IPart[] Part { get; set; }

        public House(Basement[] basement, Wall[] wall, Door[] door, Window[] window, Roof[] roof)
        {
            Part = new IPart[basement.Length + wall.Length + door.Length + window.Length + roof.Length];
            int i = 0;
            foreach (Basement item in basement)
            {
                Part[i++] = item;
            }
            foreach (Wall item in wall)
            {
                Part[i++] = item;
            }
            foreach (Door item in door)
            {
                Part[i++] = item;
            }
            foreach (Window item in window)
            {
                Part[i++] = item;
            }
            foreach (Roof item in roof)
            {
                Part[i++] = item;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Part.GetEnumerator();
        }
    }
}

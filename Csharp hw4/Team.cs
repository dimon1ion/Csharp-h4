using Csharp_hw4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw4
{
    #region Workers

    class Worker : IWorker
    {
        public bool IsWork { get; set; }
        public House House { get; set; }

        public Worker(House house)
        {
            House = house;
            IsWork = false;
        }

        public void Work()
        {
            if (IsWork == false)
            {
                foreach (IPart item in House)
                {
                    if (item.IsInstal == false)
                    {
                        item.Instal();
                        break;
                    }
                }
                IsWork = true;
            }
        }
    }
    class TeamLeader : IWorker
    {
        public House House { get; set; }

        public TeamLeader(House house)
        {
            House = house;
        }

        public void Work()
        {
            Console.WriteLine("Teamleader:");
            foreach (IPart item in House)
            {
                Console.WriteLine($"{item.Name}: {(item.IsInstal ? "Instal" : "Not Instal")}");
            }
            Console.WriteLine();
        }
    }
    
    #endregion

    class Team
    {
        public IWorker[] Worker { get; set; }

        public Team(House house)
        {
            Worker = new IWorker[house.Part.Length + 1];
            Worker[0] = new TeamLeader(house);
            for (int i = 1; i <= house.Part.Length; i++)
            {
                Worker[i] = new Worker(house);
            }
        }
        public IWorker this[int index]
        {
            get
            {
                return (IWorker)Worker[index];
            }
        }
    }
}

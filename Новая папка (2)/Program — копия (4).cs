using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Pet
    {
        private string name;
        private int energy;
        public string Name { get { return name; } set { name = value; } }
     
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                    energy = value;
                else
                    Console.WriteLine("Энергия  должен быть от 0 до 100.");
            }
        }
        public Pet(string name, int energy) { 
            this.name = name;
            if (energy >= 0 && energy <= 100)
            {
                this.energy = energy;
            }
            else
            {
                Console.WriteLine("Энергия должна быть от 0 до 100!");
                this.energy = 50; 
            }
        }
        
        public void Play()
        {
            int Energy = energy - 20;
            if (Energy < 0)
               Energy  = 0;

            energy= Energy;
            Console.WriteLine($"{name} играет, эергия: {energy}");
        }
        public void Rest()
        {
            int Energy = energy + 30;
            if (Energy < 100)
               Energy = 100;

            energy = Energy;
            Console.WriteLine($"{name} играет, энергия: {energy}");
        }


    }
    class Program
    {
        static void Main()
        {
            Pet pеt = new Pet("Флафи", 40);
            pеt.Play();
            pеt.Rest();
            Pet Pet1 = new Pet("Флафи", 124);
            Pet1.Play();
            Console.ReadLine();

        }
    }
}



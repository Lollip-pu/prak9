using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set {
                if (value >= 0 && value <= 120)
                    age = value;
                else
                    Console.WriteLine("Возраст должен быть от 0 до 120");
            } }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age >= 0 && age <= 120 ? age : 0;
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {name} , мне {age} лет.");

        }
    }




     class Program{
        static void Main()
        {
                Person person = new Person("Лилия", 25);
                person.SayHello();
                person.Age = 150;
                person.SayHello();
                person.Age = -5;
                person.SayHello();
                Console.ReadLine();


            }
    }
}

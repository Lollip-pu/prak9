using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4
{
    class Circle
    {
        private double radius;
        public double Radius {  get { return radius; } set { 
                if(value > 0 )
                radius = value;
            else
                    Console.WriteLine("Радиус должен быть больше 0.");
            } }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }

 }
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(6);
            circle.GetArea();
            Circle circle1 = new Circle(-2);
            circle1.GetArea();
            Console.ReadLine();        }
    }
    
}

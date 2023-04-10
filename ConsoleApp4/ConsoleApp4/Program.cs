using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   
       interface iCal
    {
        void Rectangle();
        void Circle();
        void Square();
        void Triangle();


    } 
        class CalcArea:iCal
        {
            float length, breadth, radius, side, height, breadthForTriangle;

            public void Rectangle()
            {
                Console.WriteLine("Enter the Length for Rectangle:");
                length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the breadth for Rectangle:");
                breadth = float.Parse(Console.ReadLine());
                Console.WriteLine("Area of rectangle is: {0}", length * breadth);
            }

            public void Circle()
            {
                Console.WriteLine("Enter the Radius of the Circle:");
                radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Area of Circle is: {0}", 3.14* radius * radius);
            }

            public void Square()
            {
                Console.WriteLine("Enter the Length of the side of the Square:");
                side = float.Parse(Console.ReadLine());
                Console.WriteLine("Area of Square is: {0}", side * side);
            }

            public void Triangle()
            {
                Console.WriteLine("Enter the Height of the Triangle:");
                height = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Breadth of the Triangle:");
                breadthForTriangle = float.Parse(Console.ReadLine());
                Console.WriteLine("Area of Triangle is: {0}", 0.5 * height * breadthForTriangle);
            }

        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance of CalcArea class
                CalcArea calculator = new CalcArea();
              
                //iCal calculator = new iCal();
                // Call the methods to calculate areas
                calculator.Rectangle();
                calculator.Circle();
                calculator.Square();
                calculator.Triangle();

                Console.ReadKey();
            }
        }

    }
}



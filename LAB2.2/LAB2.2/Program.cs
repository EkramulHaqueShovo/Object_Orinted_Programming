using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2._2
{

    class Emp
    {

        string name { get; set; }
        double age { get; set; }
        float salary { get; set; }

        public Emp(string name, double age, float salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
       public void displayDetails()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Age: " + age);
            System.Console.WriteLine("salary: " + salary);
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Emp E1 = new Emp("Ekramul",20,200000);
            Emp E2 = new Emp("Haque",22,300000);

            E1.displayDetails();
            E2.displayDetails();
            Console.ReadLine();
        }
    }
}

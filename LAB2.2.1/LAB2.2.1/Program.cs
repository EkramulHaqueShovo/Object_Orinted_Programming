using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2._2._1
{ 
    class Emp
    {
        string name{ set; get; }
        int age { set; get; }
        int salary { set; get; }

        public Emp(string name, int age,int salary) {
          this.name = name; 
          this.age = age;
          this.salary = salary;
        }
        public void displayDetails()
        {
            Console.WriteLine("Employe name:"+name);
            Console.WriteLine("Employe age:"+age);
            Console.WriteLine("Employe salary:"+salary);


        }


    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp[] E1 = new Emp[10];
            for(int i =0; i<10; i++)
            {
                Console.WriteLine("Emplyee number  {0}: ",i+1);
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Salary :");
                int salary = int.Parse(Console.ReadLine());


            }


        }
    }
}

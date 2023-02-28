using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB2._1
{

     class student
    {
         string name;
         int age;
         int[] marks = new int[3];
         double avg;


        public student(string name, int age, int[] marks) {
        this.name = name;
        this.age = age;
        this.marks = marks;


        }
        public void calculateAverage()
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            avg = sum / marks.Length;
        }



        public void displayDetails()
        {
            Console.WriteLine("Student information: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Average Marks: " +avg);
        }

    }
    class Program

    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Student name:" );
             string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the marks :");
            int []marks = new int[3];
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i]= int.Parse(Console.ReadLine());
            }

            student s1 = new student(name,age,marks);
            s1.displayDetails();
            s1.calculateAverage();
            


            Console.ReadLine();


        }
    }
}

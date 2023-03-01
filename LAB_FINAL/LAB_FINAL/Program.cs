using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_FINAL
{

    class person
    {
        private string name;
        private string dob;
        public person() { }
        public person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;

        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }
        public string getDob()
        {
            return this.dob;
        }
    }
    class Employee : person
    {

    

       private string acc;
        public Employee():base() { }
        public Employee(string name, string dob, string acc):base(name,dob)
        {
          
            this.acc = acc;
        }
      public void setAcc(string acc)
        {
            this.acc = acc;
        }
        public void display()
        {
            Console.WriteLine("Employee information :\n");
            Console.WriteLine("Employee name :" + getName());
            Console.WriteLine("Employee dob :" + getDob());
            Console.WriteLine("Employee acc " + acc);
        }
    }
    class customer:person
    {
        private string acc;
        public customer():base() { }
        public customer(string name, string dob, string acc):base(name,dob)
        {
            
            this.acc = acc;
        }
        public void setAcc(string acc)
        {
            this.acc = acc;
        }
        public void display()
        {
            Console.WriteLine("Customer information:\n");
            Console.WriteLine("Customer name :" + getName());
            Console.WriteLine("Customer dob : " + getDob());
            Console.WriteLine("Customer acc  :" + acc);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee("Ekramul","08-12-2000","deposit");
            customer C1 = new customer("Rabbi","01-2-2001","saving");
            E1.display();
            Console.WriteLine("Customer information: ");
            C1.display();
            Console.ReadLine();
        }
    }
}

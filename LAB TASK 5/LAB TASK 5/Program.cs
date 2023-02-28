using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_5
{

   

    public class Person
    {
        private string name;
        private string dob;

        public Person()
        {
          
        }

        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public string getName()
        {
            return name;
        }

        public string getDob()
        {
            return dob;
        }
    }

    public class Account
    {
        private int accountId;
        private double amount;
        private string accType;

        public Account(int accountId, double amount, string accType)
        {
            this.accountId = accountId;
            this.amount = amount;
            this.accType = accType;
        }

        public int getAccountId()
        {
            return accountId;
        }

        public double getAmount()
        {
            return amount;
        }

        public string getAccType()
        {
            return accType;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }
    }

    public class Employee : Person
    {
        private Account acc;

        public Employee() : base()
        {
          
        }

        public Employee(string name, string dob, Account acc) : base(name, dob)
        {
            this.acc = acc;
        }

        public void setAcc(Account acc)
        {
            this.acc = acc;
        }

        public void display()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine("Employee Name: " + getName());
            Console.WriteLine("Employee DOB: " + getDob());
            Console.WriteLine("Account ID: " + acc.getAccountId());
            Console.WriteLine("Account Type: " + acc.getAccType());
            Console.WriteLine("Account Amount: " + acc.getAmount());
        }
    }

    public class Customer : Person
    {
        private Account acc;

        public Customer() : base()
        {
           
        }

        public Customer(string name, string dob, Account acc) : base(name, dob)
        {
            this.acc = acc;
        }

        public void setAcc(Account acc)
        {
            this.acc = acc;
        }

        public void display()
        {
            Console.WriteLine("\nCustomer Information:");
            Console.WriteLine("Customer Name: " + getName());
            Console.WriteLine("Customer DOB: " + getDob());
            Console.WriteLine("Account ID: " + acc.getAccountId());
            Console.WriteLine("Account Type: " + acc.getAccType());
            Console.WriteLine("Account Amount: " + acc.getAmount());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Account empA = new Account(123456, 5000.0, "Checking");
            Employee emp1 = new Employee("Efty", "01/01/1999", empA);
            
            emp1.display();
            Account cusA = new Account(654321, 2500.0, "Savings");
            Customer cus1 = new Customer("Mahzabin", "02/03/2002", cusA);
          
            cus1.display();
            Console.ReadLine();
        }
        
    }


}

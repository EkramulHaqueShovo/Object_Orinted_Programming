using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

interface BasicCalculatorInterface
{
    int sum(int x, int y);
    int sub(int x, int y);
    int mul(int x, int y);
    int div(int x, int y);
}

interface ScientificCalculatorInterface
{
    int XtoY(int x, int y);
  
}

class Calculator : BasicCalculatorInterface, ScientificCalculatorInterface
{
    public int sum(int x, int y)
    {
        return x + y;
    }

    public int sub(int x, int y)
    {
        return x - y;
    }

    public int mul(int x, int y)
    {
        return x * y;
    }

    public int div(int x, int y)
    {
       
        return x / y;
    }

    public int XtoY(int x, int y)
    {
        return (int)Math.Pow(x, y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator c1 = new Calculator();


        Console.WriteLine("Calculator: ");
        Console.WriteLine("Enter 1st number: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"{x}+{y} = {c1.sum(x, y)}");
        Console.WriteLine($"{x}-{y} = {c1.sub(x, y)}");
        Console.WriteLine($"{x}*{y} = {c1.mul(x, y)}");
        try
        {
            Console.WriteLine($"{x}/{y} = {c1.div(x, y)}");

        }catch(DivideByZeroException)
        {
            Console.WriteLine("Cant divide number with zero!!!");
        }
      
        
        Console.ReadLine();





        

        
    }
}








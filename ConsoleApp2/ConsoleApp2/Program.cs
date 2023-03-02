using System;

class Program
{
    static void Main()
    {
        double t1, t2, totalTime;

        
        double fractionCompletedByT1 = 1.0 / 20;
        double fractionCompletedByT2 = 1.0 / 15;

       
        double workDoneInOneMinute = fractionCompletedByT1 + fractionCompletedByT2;

       
        Console.Write("Enter the total time T1 and T2 worked together (in minutes): ");
        totalTime = double.Parse(Console.ReadLine());

       
        double totalWorkDone = workDoneInOneMinute * totalTime;

        
        double fractionCompletedByT2InGivenTime = fractionCompletedByT2 / workDoneInOneMinute * totalTime;

      
        double timeSpentByT1 = totalTime - fractionCompletedByT2InGivenTime * 60;

        Console.WriteLine("T1 stopped working after " + timeSpentByT1 + " minutes.");
        Console.ReadLine();
    }
}

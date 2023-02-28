using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {

        string[][] studentData = new string[5][];
        int[][] marks = new int[5][];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter the details of student " + (i + 1));
            Console.Write("Enter name: ");
            studentData[i] = new string[] { Console.ReadLine() };
            marks[i] = new int[3];

            Console.WriteLine("Enter marks for 3 subjects:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Subject " + (j + 1) + ": ");
                marks[i][j] = int.Parse(Console.ReadLine());
            }
        }

        int highestAverageIndex = 0;
        float highestAverage = 0;

        for (int i = 0; i < 5; i++)
        {
            float average = 0;
            for (int j = 0; j < 3; j++)
            {
                average += marks[i][j];
            }
            average /= 3;

            Console.WriteLine("Average marks of " + studentData[i][0] + ": " + average);

            if (average > highestAverage)
            {
                highestAverage = average;
                highestAverageIndex = i;
            }
        }

        Console.WriteLine("\nStudent with highest average marks: " + studentData[highestAverageIndex][0]);
        Console.WriteLine("Average marks: " + highestAverage);
    }
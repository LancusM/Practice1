using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string score;
            Console.WriteLine("Input your grade here: ");
            int grade = Convert.ToInt16(Console.ReadLine());
            if (grade <= 59)
            {
                score = "F";
            }
            else
            {
                if (grade <= 69)
                {
                    score = "D";
                }
                else
                {
                    if (grade <= 79)
                    {
                        score = "C";
                    }
                    else
                    {
                        if (grade <= 89)
                        {
                            score = "B";
                        }
                        else
                        {
                            score = "A";
                        }
                    }
                }
            }
            Console.WriteLine("Your grade is: " + score);
            Console.Read();
        }
    }
}
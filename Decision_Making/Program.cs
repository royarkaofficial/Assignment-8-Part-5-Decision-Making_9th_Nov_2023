using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your exam score as a percentage: ");
            double exam_Score = double.Parse(Console.ReadLine());
            char grade; // Variable to store the letter grade
            // Use if-else statements to determine the letter grade
            if (exam_Score >= 90)
            {
                grade = 'A';
            }
            else if (exam_Score >= 80)
            {
                grade = 'B';
            }
            else if (exam_Score >= 70)
            {
                grade = 'C';
            }
            else if (exam_Score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            // Display the letter grade to the user
            Console.WriteLine($"Your letter grade is: {grade}");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
            string input = Console.ReadLine();

            // Validate user input
            if (float.TryParse(input, out float gradePercentage))
            {
                // Determine letter grade
                string letter = GetLetterGrade(gradePercentage);

                // Determine sign (+, -, or none)
                string sign = GetSign(gradePercentage, letter);

                // Print letter grade and sign
                Console.WriteLine($"Your grade is {letter}{sign}");

                // Determine if user passed the course
                if (gradePercentage >= 70)
                {
                    Console.WriteLine("Congratulations, you passed the course!!!");
                }
                else
                {
                    Console.WriteLine("Better luck next semester!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid percentage.");
            }
        }

        static string GetLetterGrade(float gradePercentage)
        {
            if (gradePercentage >= 90)
            {
                return "A";
            }
            else if (gradePercentage >= 80)
            {
                return "B";
            }
            else if (gradePercentage >= 70)
            {
                return "C";
            }
            else if (gradePercentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static string GetSign(float gradePercentage, string letter)
        {
            // Special cases: A+, F+, F-
            if (letter == "A" || letter == "F")
            {
                return "";
            }

            int lastDigit = (int)(gradePercentage % 10);
            if (lastDigit >= 7)
            {
                return "+";
            }
            else if (lastDigit < 3)
            {
                return "-";
            }
            else
            {
                return "";
            }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            while (true)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    if (number == 0)
                    {
                        break;
                    }
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            // Core Requirements
            double sum = numbers.Sum();
            double average = numbers.Average();
            double max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenges
            double smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(double.MaxValue).Min();
            if (smallestPositive != double.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }

            var sortedNumbers = numbers.OrderBy(n => n);
            Console.WriteLine("The sorted list is:");
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
}
}
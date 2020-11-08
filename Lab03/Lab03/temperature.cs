using System;

{
    class Program
{
    static void Main()
    {
            Console.Write("Please input a temperature in Fahrenheit: ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The temperature in Celsius is: " + (fahrenheit - 32d) * 5d / 9d);

            if (fahrenheit >= 90)
            {
                Console.WriteLine("It is hot outside.");    
            }
            if (fahrenheit <= 32)
            {
                Console.WriteLine("It is cold outside.");
            }
        }
    }
}
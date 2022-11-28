//Napisz program przeliczający temperaturę w stopniach Celsjusza na temperaturę w
//stopniach Fahrenheita. Program ma prosić użytkownika o podanie temperatury w stopniach
//Celsjusza. Wzór: F=32+(5/9)C.

using System;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter degrees Celsius: ");
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine("Value in Fahrenheit: " + Farenheit(C));
        }
        static double Farenheit(double C)
        {
            double F = 32 + C * 9 / 5;
            return F;
        }
    }
}

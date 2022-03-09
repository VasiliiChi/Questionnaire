using System;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hi! Your name is {0} and age is {1}.",name, age);
            Console.Write("Enter your birthday in the xx(day).xx(month).xxxx(year) format: ");
            var birthday = Console.ReadLine();
            Console.Write($"Your birthday is {birthday}");
            Console.ReadKey();
        }
    }
}

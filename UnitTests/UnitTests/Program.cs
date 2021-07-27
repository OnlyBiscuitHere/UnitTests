using System;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            var greeting = Greeting(timeOfDay);
            Console.WriteLine(greeting);
            Console.WriteLine(Greeting(timeOfDay));
        }
        private static string Greeting(int timeOfDay)
        {
            string greeting;
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                greeting = "Good moring!";
            }
            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                greeting = "Good afternoon!";
            }
            else
            {
                greeting = "Good evening!";
            }
            return greeting;
        }
    }
}

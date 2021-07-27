using System;

namespace CSharpHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;
            if (ageOfViewer <= 12)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer <= 15)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
            return result;
        }
    }
}

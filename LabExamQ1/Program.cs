
namespace LabExamQ1
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] daysOfWeek = new string[]
       {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
       };
            var daysQuery = from day in daysOfWeek
                            select day;

            foreach (var day in daysQuery)
            {
                Console.WriteLine(day);
            }
        }
    }
}
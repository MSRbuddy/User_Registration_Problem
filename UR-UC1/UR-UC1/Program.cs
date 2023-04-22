using System.Text.RegularExpressions;

namespace UR_UC1
{
    internal class Program
    {
        public static string FirstName = @"^[A-Z][a-z]{2,10}$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid FirstName*****!");
            Console.WriteLine("-----------------------------");

            Regex r = new Regex(Program.FirstName);
            Console.WriteLine("\nEnter User First Name: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
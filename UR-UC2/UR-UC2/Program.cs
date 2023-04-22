using System.Text.RegularExpressions;

namespace UR_UC2
{
    internal class Program
    {
        public static string LastName = @"^[A-Z][a-z]{2,10}$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid LastName*****!");
            Console.WriteLine("----------------------------");

            Regex r = new Regex(Program.LastName);
            Console.WriteLine("\nEnter User Last Name: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
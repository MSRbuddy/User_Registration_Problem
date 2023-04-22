using System.Text.RegularExpressions;

namespace UR_UC4
{
    internal class Program
    {
        public static string PhoneNumber = @"^[9]?[1]?[ ][6-9]?[0-9]{9}$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid Phone Number*****!");
            Console.WriteLine("--------------------------------");

            Regex r = new Regex(Program.PhoneNumber);
            Console.WriteLine("\nEnter User Contact Number: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
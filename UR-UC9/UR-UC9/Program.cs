using System.Text.RegularExpressions;

namespace UR_UC9
{
    internal class Program
    {
        public static string SampleEmail = @"^\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid Sample Email-Id!*****");
            Console.WriteLine("-----------------------------------");

            Regex r = new Regex(Program.SampleEmail);
            Console.WriteLine("\nEnter User Sample Email: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
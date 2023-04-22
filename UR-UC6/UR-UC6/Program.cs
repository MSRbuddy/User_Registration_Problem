using System.Text.RegularExpressions;

namespace UR_UC6
{
    internal class Program
    {
        public static string PwdRule2 = @"^[A-Z]{1,3}[a-z]{5,20}$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid Password(Rule-2)!*****");
            Console.WriteLine("------------------------------------");

            Regex r = new Regex(Program.PwdRule2);
            Console.WriteLine("\nEnter User Password(Rule2) : ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
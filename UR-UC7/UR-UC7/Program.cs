using System.Text.RegularExpressions;

namespace UR_UC7
{
    internal class Program
    {
        public static string PwdRule3 = @"^[A-Z]{1,3}[a-z]{2,20}[0-9]{1,3}$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid Password(Rule-3)!*****");
            Console.WriteLine("------------------------------------");

            Regex r = new Regex(Program.PwdRule3);
            Console.WriteLine("\nEnter User Password(Rule3) : ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
using System.Text.RegularExpressions;

namespace UR_UC8
{
    internal class Program
    {
        public static string PwdRule4 = @"^[A-Z]{1,3}[a-z]{2,20}[-\#\$\@\%\&\+]?[0-9]{1,3}";
        static void Main(string[] args)
        {
            Console.WriteLine("****Valid Password(Rule-4)!*****");
            Console.WriteLine("------------------------------------");

            Regex r = new Regex(Program.PwdRule4);
            Console.WriteLine("\nEnter User Password(Rule4) : ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
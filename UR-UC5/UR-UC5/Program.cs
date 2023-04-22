using System.Text.RegularExpressions;

namespace UR_UC5
{
    internal class Program
    {
        public static string PwdRule1 = @"^[A-Za-z]{8,20}$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid Password(Rule-1)*****!");
            Console.WriteLine("------------------------------------");

            Regex r = new Regex(Program.PwdRule1);
            Console.WriteLine("\nEnter User Password(Rule1) : ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
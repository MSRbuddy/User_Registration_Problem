using System.Text.RegularExpressions;

namespace UR_UC3
{
    internal class Program
    {
        public static string MailId = @"^[a-z0-9|a-z0-9.a-z]@[a-z|a-z.a-z{2}]|[.a-z{2}]$";
        static void Main(string[] args)
        {
            Console.WriteLine("*****Valid Email-Id*****!");
            Console.WriteLine("-----------------------------");

            Regex r = new Regex(Program.MailId);
            Console.WriteLine("\nEnter User Email Id: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace Regex_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\s[A-Za-z0-9][\w+\.-]*\@[A-Za-z-]+)(\.[A-Za-z-]+)+";
            MatchCollection allEmails = Regex.Matches(input, pattern);

            foreach (Match item in allEmails)
            {
                Console.WriteLine(item.ToString().Remove(0,1));
            }
        }
    }
}

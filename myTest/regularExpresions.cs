using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Hello_world 
{
    class RegularExpressions
    {
        internal void Reg()
        {
            string pattern = @"(\+56)?\s?(9|2)\s?(\d{4})\s?\d{4}";
            string text = "Hi, my phone number is: +56 9 1234 5678 or you can also use +56 2 1234 5678";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("{0} matches within \"{1}\"", matches.Count,text);

            foreach (Match i in matches)
            {
                GroupCollection group = i.Groups;
                Console.WriteLine("{0} found in index {1}", group[0].Value, group[0].Index);
            }

            Console.Read();
        }
    }
}

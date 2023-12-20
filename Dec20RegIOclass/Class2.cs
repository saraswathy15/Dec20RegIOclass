using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dec20RegIOclass
{
    class test1
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex("");
            // Create a pattern for a word that starts with the letter "M"
            // Create a pattern for a word that starts with the letter "M"
            string pattern = @"\b[M]\w+";
            // Create a Regex
            Regex rg = new Regex(pattern);
            // Long string
            string authors = "Mohit, Raj Kumar, Mangesh , amit, Madan kumar";
            // Get all matches
            MatchCollection matchedAuthors = rg.Matches(authors);
            // Print all matched authors
            for (int count = 0; count < matchedAuthors.Count; count++)
                Console.WriteLine(matchedAuthors[count].Value);
            Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
            //class Regex represents an immutable regular expression.
            string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
            //Input strings for Match valid mobile number.
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                r.IsMatch(s) ? "is" : "is not");
                //The IsMatch method is used to validate a string or
                //to ensure that a string conforms to a particular pattern.
            }
            // splits digits from string
            string Text = "1 One, 2 Two, 3 Three is good.";

            string[] digits = Regex.Split(Text, @"\D+");

            foreach (string value in digits)
            {
                int number;
                if (int.TryParse(value, out number))
                {
                    Console.WriteLine(value);
                }
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            // Input strings to Match
            // valid mobile number
            string[] str = {"9925612824",
          "8238783138", "02812451830"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                            isValidMobileNumber(s) ? "is" : "is not");
            }

            Console.ReadKey();
        }

        // method containing the regex
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            // Class Regex Represents an
            // immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx           ^[0 - 9]{ 10}$
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate
            // a string or to ensure that a string
            // conforms to a particular pattern.
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
    }
    internal class Class2
    {
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dec20RegIOclass
{
    internal class ExampleReg
    {
        //define a string pattern , pass pattern to instance of regex class
        static string pat = "^a...e$";
        static void Main(string[] args)
        {
            Regex reg = new Regex(pat);

            if (reg.IsMatch("apple")) Console.WriteLine("yessssssssss"); else Console.WriteLine("nooooooooo");
            Console.ReadLine();
        }
    }
}

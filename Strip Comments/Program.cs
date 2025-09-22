using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {



            Console.WriteLine(StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));
            Console.WriteLine(StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
        }

        public static string StripComments(string text, string[] commentSymbols)
        {

            

            return "";
        }
    }
}
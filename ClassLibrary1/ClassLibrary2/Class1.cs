using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public string RemoveSpecialCharactersFromString(string inputString)
        {
            return RemoveSpecialChar(inputString);
        }


        private static string RemoveSpecialChar(string inputstring)
        {
            inputstring = Regex.Replace(inputstring, @"[^0-9a-zA-Z\._]", string.Empty);
            return inputstring;
        }
    }
}

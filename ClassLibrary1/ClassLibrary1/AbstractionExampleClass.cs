using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    /// <summary>
    /// it is the process to hide the internal details and show only the functionality
    /// Showing necessary info to the user & not showing the unnecessay info
    /// Hiding the business logic to out side the world
    /// </summary>
    public class AbstractionExampleClass
    {
        public string RemoveSpecialCharactersFromString(string inputString)
        {
            return RemoveSpecialChar(inputString);
        }


        private static string RemoveSpecialChar(string inputstring)
        {
            inputstring= Regex.Replace(inputstring, @"[^0-9a-zA-Z\._]", string.Empty);
            return inputstring;
        }
    }
}

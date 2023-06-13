using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLib
{
    public class Program
    {
        public static bool CheckForPallindrome(string input)
        {
            if (input == "" || input == " " || input.Length == 1)
            {
                return false;
            }
            return input.SequenceEqual(input.Reverse());
        }
    }
}

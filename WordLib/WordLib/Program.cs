﻿using System;
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
            if (string.IsNullOrWhiteSpace(input) == true)
            {
                throw new ArgumentException("wrong input", "input");
            }

            if (input.SequenceEqual(input.Reverse()) == false)
            {
                return false;
            }
            
            return true;
        }
    }
}

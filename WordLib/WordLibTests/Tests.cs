using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLib;
using Xunit;

namespace WordLibTests
{
    public class Tests
    {
        /*
            if 0 words, 1 space or 1 letter return flase because its not a word
        */


        [Fact]
        public void IsPallindromeTest()
        {
            //Arrange
            string myString = "lol";

            //Act
            bool isPalindrome = myString.SequenceEqual(myString.Reverse());


            //Assert
            Assert.True(isPalindrome);

            
        }
    }
}

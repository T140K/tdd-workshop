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


        [Theory]
        [InlineData("book")]
        [InlineData("boob")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("a")]

        public void IsPallindromeTest(string myString)
        {
            //Arrange


            //Act
            bool isPalindrome = myString.SequenceEqual(myString.Reverse());


            //Assert
            Assert.True(isPalindrome);

            
        }
    }
}

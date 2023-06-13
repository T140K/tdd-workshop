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
            if 0 or 1 space should fail, otherwise it is a pallindrome by the definition
        */


        [Theory]
        [InlineData("boob")]//should pass
        [InlineData("a")]//should pass
        [InlineData("aa")]//should pass
        [InlineData("book")]//rest should fail
        [InlineData("ab")]//should pass
        [InlineData("")]
        [InlineData(" ")]


        public void IsPallindromeTest(string myString)
        {
            //Arrange


            //Act
            bool isPalindrome = Program.CheckForPallindrome(myString);


            //Assert
            Assert.True(isPalindrome);

            
        }
    }
}

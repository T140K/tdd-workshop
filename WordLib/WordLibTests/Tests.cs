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

        //tests that should pass
        [Theory]
        [InlineData("boob")]
        [InlineData("a")]
        [InlineData("aa")]
        public void IsPallindrome_TestShouldPass(string myString)
        {
            //Arrange


            //Act
            bool isPalindrome = Program.CheckForPallindrome(myString);


            //Assert
            Assert.True(isPalindrome);

            
        }

        //should fail because of whitespace
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void IsPallindrome_TestShouldThrowException(string myString)
        {

            Assert.Throws<ArgumentException>("input", () => Program.CheckForPallindrome(myString));

        }

        //should fail because of wrong input
        [Theory]
        [InlineData("hello")]
        [InlineData("ab")]
        public void IsPallindrome_TestShouldReturnFalse(string myString)
        {

            Assert.False(Program.CheckForPallindrome(myString));

        }
    }
}

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

        [Theory]
        [InlineData("log")]
        [InlineData("glogg")]
        public void InputWordLengthChecker(string input)
        {
            //Arrange
            string expected = "this is a short word";

            //Act
            Program.Counter(input);

            //Assert
            Assert.Equal(expected, Program.Counter(input));
        }

        [Theory]
        [InlineData("logger")]
        public void InputWordLengthChecker_ShouldFail(string input)
        {
            //Arrange
            string expected = "this is a short word";

            //Act
            Program.Counter(input);
            

            //Assert
            Assert.NotSame(expected, Program.Counter(input));
        }
    }
}

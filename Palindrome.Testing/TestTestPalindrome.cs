using System;
using Xunit;



namespace Palindrome.Testing
{
    public class TestTestPalindrome
    {
      [Theory]
        [InlineData("Mary")] //should fail
        [InlineData("Donnilas")] //should fail
        [InlineData("Renal")] //should fail
        [InlineData("Damed")] //should fail
        [InlineData("G@@g")] //should pass (does not though)
        [InlineData("Beneb beneb")] //should pass
        public void Test1(string s)
        {
            //arrange
            Palindrome.Domain.TestPalindrome sut = new Palindrome.Domain.TestPalindrome();
            //act
            bool b=sut.TestPal(s);
            //assert
            Assert.True(b);

        }
    }
}

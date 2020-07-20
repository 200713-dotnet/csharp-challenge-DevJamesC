using System;
using Xunit;



namespace Palindrome.Testing
{
    public class TestTestPalindrome
    {
      [Theory]
        [InlineData("Mary")]
        [InlineData("Donnilas")]
        [InlineData("Renal")]
        [InlineData("Damad")]
        [InlineData("Goog")]
        [InlineData("Beneb")]
        public void Test1(string s)
        {
            Palindrome.Domain.TestPalindrome sut = new Palindrome.Domain.TestPalindrome();

            bool b=sut.TestPal(s);

            Assert.True(b);

        }
    }
}

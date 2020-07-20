using System;
using Xunit;



namespace Palindrome.Testing
{
    public class UnitTest1
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
            Palindrome.Domain.Class1 sut = new Palindrome.Domain.Class1();

            bool b=sut.TestPal(s);

            Assert.True(b);

        }
    }
}

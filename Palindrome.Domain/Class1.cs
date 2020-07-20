using System;

namespace Palindrome.Domain
{
    public class Class1
    {


        public bool TestPal(string input)
        {
            string string1, rev;
            string1 = input;
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            return string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using KataSolutions;

namespace Tests.ArrayKatas
{
    public class Kata1
    {
        //TODO skriv en metod som vänder på innehållet i arrayer, använd for-loop

        [Theory]
        [InlineData(new[] { 0, 1 }, new[] { 1, 0 })]
        [InlineData(new[] { 0, 1, 2, 3, 4 }, new[] { 4, 3, 2, 1, 0 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 5, 4, 3, 2, 1 })]
        // Bonus tester
        //[InlineData(null, null)]
        //[InlineData(new int[] { }, new int[] { })]
        //[InlineData(new[] { 0 }, new[] { 0 })]
        public void ArrayReverserTest(int[] original, int[] rightAnswer)
        {
            Reverser.Reverse(original);

            Assert.Equal(rightAnswer, original);
        }

        // Extrem bonus - använd templating för att göra så att 'Reverse' fungerar på vilken array som helst
        /*
        [InlineData(new[] { 'A', 'B', 'C', 'D', 'E' }, new[] { 'E', 'D', 'C', 'A', 'B' })]
        public void GeneralArrayReverserTest(char[] original, char[] reverse)
        {
            Reverse(original);

            Assert.Equal(reverse, original);
        }
        */
    }
}

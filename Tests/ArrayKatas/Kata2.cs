using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataSolutions;
using Xunit;

namespace Tests.ArrayKatas
{
    public class Kata2
    {
        // TODO Skriv en metod som räknar antal ord som börjar på en bokstav
        //
        // Använd en foreach-loop
        // .ToCharArray() kan användas för att bryta ner en sträng till individuella char:s för lättare analys

        [Theory]
        [InlineData('c', 16229)]
        [InlineData('q', 822)]
        // Bonus tester
        //[InlineData('X', 136)]
        //[InlineData('\t', 0)]
        //[InlineData('}', 0)]
        public void WordCounterTest(char letter, int answer)
        {
            string[] wordBook = WordList.Enable1Words;

            int count = Counter.CountWordsWithLetter(wordBook, letter);

            Assert.Equal(answer, count);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataSolutions;
using Xunit;

namespace Tests.ArrayKatas
{
    public class Kata3
    {
        // TODO Använd 'break;' för att göra en snabbare ordräknare som utnyttjar det faktum att alla ord kommer i bokstavsordning

        [Theory]
        [InlineData('c', 16229)]
        //Bonus - gör den snabbare även för sena bokstäver
        //[InlineData('z', 822)]
        public void FasterWordCounterTest(char letter, int answer)
        {
            string[] wordBook = WordList.Enable1Words;
            Stopwatch watch;
                
            watch = Stopwatch.StartNew();
            int count1 = Counter.CountWordsWithLetter(wordBook, letter);
            watch.Stop();
            long slowTime = watch.ElapsedTicks;

            watch = Stopwatch.StartNew();
            int count2 = Counter.CountWordsWithLetterFast(wordBook, letter);
            watch.Stop();
            long fastTime = watch.ElapsedTicks;

            Assert.Equal(answer, count1);
            Assert.Equal(answer, count2);

            Assert.True(fastTime * 2 < slowTime);
        }
    }
}

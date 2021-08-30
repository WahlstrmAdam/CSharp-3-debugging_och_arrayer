using System;
using Xunit;

namespace Tests
{
    public class ArrayTests
    {
        [Fact]
        public void NoArrayMade()
        {
            int[] salaries = null;

            Assert.Null(salaries);
            Assert.Throws<NullReferenceException>(() =>
            {
                int firstSalary = salaries[0];
            });
        }

        [Fact]
        public void ArrayExists_But_IsEmpty()
        {
            int[] salaries = new int[0];

            Assert.NotNull(salaries);
            Assert.Empty(salaries);
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int firstSalary = salaries[0];
            });
        }

        [Fact]
        public void ArrayExists_And_HasContent_But_IsUninitialized()
        {
            int[] salaries = new int[3];
            string[] names = new string[3];

            Assert.NotEmpty(salaries);
            Assert.NotEmpty(names);

            Assert.Equal(new []{0,0,0}, salaries);
            Assert.Equal(new string[] { null, null, null }, names);
        }
    }
}

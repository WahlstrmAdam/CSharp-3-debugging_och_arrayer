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


        [Fact]
        public void ArrayExample()
        {
            int age1 = 23;
            int age2 = 43;
            int age3 = 98;
            //                        0   1   2
            int[] ages = new int[] { 23, 43, 98};


            double[] productWeights = new double[4];
            productWeights[0] = 2.3;
            productWeights[1] = 2.45;
            productWeights[2] = 2.1;
            productWeights[3] = 2.20054;

            for (int productIndex = 0; productIndex < productWeights.Length; productIndex++)
            {
                productWeights[productIndex] += 0.05;
            }

            double totalProductSum = 0.0;
            foreach (double productWeight in productWeights)
            {
                totalProductSum += productWeight;
            }

            Assert.Equal(4, productWeights.Length);
        }
    }
}

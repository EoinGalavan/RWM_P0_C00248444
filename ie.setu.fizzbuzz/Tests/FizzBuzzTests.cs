using NUnit.Framework;
using UnityEngine;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [Test]
        public void FizzBuzzSimple()
        {
            int[] input = { 1, 3, 5, 7, 9, 999, 45 };
            int[] output = FizzBuzz.fizz(input);
            int[] expected = { 1, 3, 5, 7, 3, 3, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

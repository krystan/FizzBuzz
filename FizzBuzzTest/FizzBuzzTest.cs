using System.Globalization;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private Program _fizzBuzzProgram;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzzProgram = new Program();
        }

        [Test, TestCaseSource("NumbersThatAreMultiplesOfThreeButNotFive")]
        public void CalculateFizzBuzz_WereNumberDivisibleByThree_ReturnsFizz(int i)
        {
            string result = _fizzBuzzProgram.CalculateFizzBuzz(i);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test, TestCaseSource("NumbersThatAreMultiplesOfFiveButNotThree")]
        public void CalculateFizzBuzz_WereNumberDivisibleByFive_ReturnsBuzz(int i)
        {
            string result = _fizzBuzzProgram.CalculateFizzBuzz(i);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test, TestCaseSource("NumbersThatAreMultiplesOfFiveAndThree")]
        public void CalculateFizzBuzz_WereNumberDivisibleByFiveAndThree_ReturnsFizzBuzz(int i)
        {
            string result = _fizzBuzzProgram.CalculateFizzBuzz(i);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test, TestCaseSource("NumbersThatAreNotMultiplesOfThreeOrFive")]
        public void CalculateFizzBuzz_WhereNumberIsNeitherDivisibleByThreeOrFive_ReturnsNumberAsString(int i)
        {
            string result = _fizzBuzzProgram.CalculateFizzBuzz(i);

            Assert.That(result, Is.EqualTo(i.ToString(CultureInfo.InvariantCulture)));
        }

        public static int[] NumbersThatAreNotMultiplesOfThreeOrFive =
            {
                1,
                2,
                4,
                7,
                8,
                11,
                13,
                14,
                16,
                17,
                19,
                22,
                23,
                26,
                28,
                29,
                31,
                32,
                34,
                37,
                38,
                41,
                43,
                44,
                46,
                47,
                49,
                52,
                53,
                56,
                58,
                59,
                61,
                62,
                64,
                67,
                68,
                71,
                73,
                74,
                76,
                77,
                79,
                82,
                83,
                86,
                88,
                89,
                91,
                92,
                94,
                97,
                98
            };

        public static int[] NumbersThatAreMultiplesOfThreeButNotFive =
            {
                3,
                6,
                9,
                12,
                18,
                21,
                24
            };

        public static int[] NumbersThatAreMultiplesOfFiveButNotThree =
            {
                5,
                10,
                20,
                25
            };

        public static int[] NumbersThatAreMultiplesOfFiveAndThree =
            {
                15,
                30,
                45,
                60,
                75,
                90,
                105,
                120,
                135,
                150,
                165,
                180,
                195
            };

    }
}

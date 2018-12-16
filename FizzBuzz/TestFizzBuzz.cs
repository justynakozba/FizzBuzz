using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzz
{
    using NUnit.Framework;
    [TestFixture]
    class TestFizzBuzz
    {
        [Test]
        public void test_thatTestReturnSize()
        {
            FizzBuzz victim = new FizzBuzz();
            int howMany = 20;
            List<String> result = victim.CalculateForNNumbers(howMany);
            Assert.AreEqual(howMany, result.Count());
        }

        [Test]
        public void test_thatTestFizz()
        {
            FizzBuzz victim = new FizzBuzz();
            Assert.AreEqual(false, victim.isFizz(1));
            Assert.AreEqual(false, victim.isFizz(2));
            Assert.AreEqual(true, victim.isFizz(3));
            Assert.AreEqual(false, victim.isFizz(4));
            Assert.AreEqual(false, victim.isFizz(5));
            Assert.AreEqual(true, victim.isFizz(6));
            Assert.AreEqual(false, victim.isFizz(7));
            Assert.AreEqual(false, victim.isFizz(8));
            Assert.AreEqual(true, victim.isFizz(9));
            Assert.AreEqual(false, victim.isFizz(10));
            Assert.AreEqual(false, victim.isFizz(11));
            Assert.AreEqual(true, victim.isFizz(12));
            Assert.AreEqual(false, victim.isFizz(13));
            Assert.AreEqual(false, victim.isFizz(14));
            Assert.AreEqual(false, victim.isFizz(15));
            Assert.AreEqual(false, victim.isFizz(16));
            Assert.AreEqual(false, victim.isFizz(17));
            Assert.AreEqual(true, victim.isFizz(18));
            Assert.AreEqual(true, victim.isFizz(21));
            Assert.AreEqual(true, victim.isFizz(24));
            Assert.AreEqual(true, victim.isFizz(27));
            Assert.AreEqual(true, victim.isFizz(33));

        }

        [Test]
        public void test_thatTestBuzz()
        {
            FizzBuzz victim = new FizzBuzz();
            for (int i = 1; i < 40; i++)
            {
                if (i == 5 || i == 10 ||
                    i == 20 || i == 25 ||
                    i == 35 || i == 40)
                {
                    Assert.AreEqual(true, victim.isBuzz(i));
                }
                else
                {
                    Assert.AreEqual(false, victim.isBuzz(i));
                }
            }

        }

        [Test]
        public void test_thatTestFizzBuzz()
        {
            FizzBuzz victim = new FizzBuzz();
            for (int i = 1; i < 40; i++)
            {
                if (i == 15 || i == 30 ||
                    i == 45 || i == 60 ||
                    i == 75 || i == 90 )
                {
                    Assert.AreEqual(true, victim.isFizzBuzz(i));
                }
                else
                {
                    Assert.AreEqual(false, victim.isFizzBuzz(i));
                }
            }
        }

        [Test]
        public void test_thatTestIfFirstNElementsAreCorrect()
        {
            FizzBuzz victim = new FizzBuzz();
            int howMany = 40;
            List<String> result = victim.CalculateForNNumbers(howMany);
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
            Assert.AreEqual("fizz", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("buzz", result[4]);
            Assert.AreEqual("fizz", result[5]);
            Assert.AreEqual("7", result[6]);
            Assert.AreEqual("8", result[7]);
            Assert.AreEqual("fizz", result[8]);
            Assert.AreEqual("buzz", result[9]);
            Assert.AreEqual("11", result[10]);
            Assert.AreEqual("fizz", result[11]);
            Assert.AreEqual("13", result[12]);
            Assert.AreEqual("14", result[13]);
            Assert.AreEqual("fizzbuzz", result[14]);
            Assert.AreEqual("16", result[15]);
            Assert.AreEqual("17", result[16]);
            Assert.AreEqual("fizz", result[17]);
            Assert.AreEqual("19", result[18]);
            Assert.AreEqual("buzz", result[19]);
            Assert.AreEqual("fizz", result[20]);
            Assert.AreEqual("22", result[21]);
            Assert.AreEqual("23", result[22]);
            Assert.AreEqual("fizz", result[23]);
            Assert.AreEqual("buzz", result[24]);
            Assert.AreEqual("26", result[25]);
            Assert.AreEqual("fizz", result[26]);
            Assert.AreEqual("28", result[27]);
            Assert.AreEqual("29", result[28]);
            Assert.AreEqual("fizzbuzz", result[29]);
            Assert.AreEqual("31", result[30]);
            Assert.AreEqual("32", result[31]);
            Assert.AreEqual("fizz", result[32]);
            Assert.AreEqual("34", result[33]);
            Assert.AreEqual("buzz", result[34]);
            Assert.AreEqual("fizz", result[35]);
            Assert.AreEqual("37", result[36]);
            Assert.AreEqual("38", result[37]);
            Assert.AreEqual("fizz", result[38]);
            Assert.AreEqual("buzz", result[39]);
        }

        [Test]
        public void test_thatTestCheckGivenNumber()
        {
            FizzBuzz victim = new FizzBuzz();
            Assert.AreEqual("1", victim.checkNumber(1));
            Assert.AreEqual("2", victim.checkNumber(2));
            Assert.AreEqual("fizz", victim.checkNumber(3));
            Assert.AreEqual("4", victim.checkNumber(4));
            Assert.AreEqual("buzz", victim.checkNumber(5));
            Assert.AreEqual("fizz", victim.checkNumber(6));
            Assert.AreEqual("7", victim.checkNumber(7));
            Assert.AreEqual("8", victim.checkNumber(8));
            Assert.AreEqual("fizz", victim.checkNumber(9));
            Assert.AreEqual("buzz", victim.checkNumber(10));
            Assert.AreEqual("11", victim.checkNumber(11));
            Assert.AreEqual("fizz", victim.checkNumber(12));
            Assert.AreEqual("13", victim.checkNumber(13));
            Assert.AreEqual("14", victim.checkNumber(14));
            Assert.AreEqual("fizzbuzz", victim.checkNumber(15));
            Assert.AreEqual("16", victim.checkNumber(16));
            Assert.AreEqual("17", victim.checkNumber(17));
            Assert.AreEqual("fizz", victim.checkNumber(18));
            Assert.AreEqual("19", victim.checkNumber(19));
            Assert.AreEqual("buzz", victim.checkNumber(20));
            Assert.AreEqual("fizz", victim.checkNumber(21));
            Assert.AreEqual("22", victim.checkNumber(22));
            Assert.AreEqual("23", victim.checkNumber(23));
            Assert.AreEqual("fizz", victim.checkNumber(24));
            Assert.AreEqual("buzz", victim.checkNumber(25));
            Assert.AreEqual("26", victim.checkNumber(26));
            Assert.AreEqual("fizz", victim.checkNumber(27));
            Assert.AreEqual("28", victim.checkNumber(28));
            Assert.AreEqual("29", victim.checkNumber(29));
            Assert.AreEqual("fizzbuzz", victim.checkNumber(30));
            Assert.AreEqual("31", victim.checkNumber(31));
            Assert.AreEqual("32", victim.checkNumber(32));
            Assert.AreEqual("fizz", victim.checkNumber(33));
            Assert.AreEqual("34", victim.checkNumber(34));
            Assert.AreEqual("buzz", victim.checkNumber(35));
            Assert.AreEqual("fizz", victim.checkNumber(36));
            Assert.AreEqual("37", victim.checkNumber(37));
            Assert.AreEqual("38", victim.checkNumber(38));
            Assert.AreEqual("fizz", victim.checkNumber(39));
            Assert.AreEqual("buzz", victim.checkNumber(40));
        }
    }
}

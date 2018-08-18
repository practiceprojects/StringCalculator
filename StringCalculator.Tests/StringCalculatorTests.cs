using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("1, 2", 3)]
        [TestCase("2, 2", 4)]
        [TestCase("3, 3, 3", 9)]
        [TestCase("//;\n1;2")]
        public void Add_Returns_Expected_Value(string input, int expected)
        {
            var calc = new StringCalculator();

            var result = calc.Add(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}





//TESTS BEFORE REFACTORING

//[Test]
//public void Add_Returns_1_For_1()
//{
//    var calc = new StringCalculator();

//    var result = calc.Add("1");

//    Assert.That(result, Is.EqualTo(1));
//}

//[Test]
//public void Add_Returns_2_For_2()
//{
//    var calc = new StringCalculator();

//    var result = calc.Add("2");

//    Assert.That(result, Is.EqualTo(2));
//}

//[Test]
//public void Add_Returns_3_For_1Comma2()
//{
//    var calc = new StringCalculator();

//    var result = calc.Add("1,2");

//    Assert.That(result, Is.EqualTo(3));
//}

//[Test]
//public void Add_Returns_4_For_2Comma2()
//{
//    var calc = new StringCalculator();

//    var result = calc.Add("2,2");

//    Assert.That(result, Is.EqualTo(4));
//}
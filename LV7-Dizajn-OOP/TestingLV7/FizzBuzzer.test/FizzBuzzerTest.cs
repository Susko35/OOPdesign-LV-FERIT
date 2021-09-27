using NUnit.Framework;

namespace FizzBuzzer.test
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void Convert_When1_Returns1()
        {
            //Arrange
            FizzBuzzer fizzbuzzer = new FizzBuzzer();
            int input = 15;
            string expected = "1";
            //Act
            string actual = fizzbuzzer.Convert(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

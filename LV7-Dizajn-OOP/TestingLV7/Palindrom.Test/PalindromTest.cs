using NUnit.Framework;
using System;

namespace Palindrom.Test
{
    [TestFixture]
    public class PalindromTest
    {
        //Provjere Convert metode

        [TestCase("jednostavno")]
        [TestCase("jednoStavno")]
        [TestCase("jednostavnoo")]
        [TestCase("onvatsondej")]
        public void Convert_When_SimpleWord(String input)
        {
            //Arrange
            Palindrom palindrom = new Palindrom();
            String expected = "onvatsondej";
            //Act
            String actual = palindrom.Convert(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ImaVe,.likaSl,,ova I Razmak")]
        [TestCase("ImaVelikaSlovaIRazmak")]
        [TestCase("nijeispravnarijec")]
        public void Convert_When_ContainsOther(String input)
        {
            //Arrange
            Palindrom palindrom = new Palindrom();
            String expected = "kamzariavolsakilevami";
            //Act
            String actual = palindrom.Convert(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Provjere checkPalindrome metode
        [TestCase("Tenet")]
        [TestCase("Top spot")]
        [TestCase("NotPalindrome")]
        [TestCase("Eva, can I see bees in a cave")]
        [TestCase("Tops spot")]
        [TestCase("miaain")]
        public void CheckPalindrome(String input)
        {
            //Arrange
            Palindrom palindrom = new Palindrom();
            bool expected = true;
            //Act
            bool actual = palindrom.CheckPalindrome(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

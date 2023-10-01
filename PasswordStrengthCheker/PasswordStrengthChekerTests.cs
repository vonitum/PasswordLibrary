using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordLibrary;

namespace UserRegistrationTests
{
    [TestClass]
    public class PasswordStrengthChekerTests
    {
        /// <summary>
        /// Верхний регистр 1, нижний регистр 1, цифра 1, спецсимвол 1, длина строки > 7(сложность 5
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_AllChars_SPoints()
        {
            //arrange
            string password = "P2ssw0rd#";
            int expected = 5;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Верхний регистр 1, за длину строки 1б, за нижний регистр 1 (сложность 3)
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_UpperCase_SPoints()
        {
            //arrange
            string password = "Password";
            int expected = 3;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Верхний регистр 1, за длину строки 1б, за нижний регистр 1, за цифру 1 (сложность 4)
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_Numbers_SPoints()
        {
            //arrange
            string password = "Passw0ord";
            int expected = 4;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Верхний регистр 1, за нижний регистр 1 (сложность 2)
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_SmalPassword_SPoints()
        {
            //arrange
            string password = "Passw";
            int expected = 2;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///  кирилица
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_CyrillicPassword_SPoints()
        {

            //Arrange
            PasswordClass passwordChecker = new PasswordClass();
            string password = "Иванов";

            //Act
            Action actual = () => PasswordClass.PasswordStrengthCheker(password);

            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// Верхний регистр 1, за нижний регистр 1 (сложность 2)
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_Empty_SPoints()
        {
            //arrange
            string password = String.Empty;
            int expected = 0;
            //act
            int actual = PasswordClass.PasswordStrengthCheker(password);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

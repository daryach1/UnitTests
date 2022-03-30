using ClassLibraryPassword;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryPasswordTests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        [TestMethod]
        public void ValidatePasswordTest()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Check_4Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "Aq1$";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Check_PasswordWithoutLowerSymbol()
        {
            //Arrange
            string password = "ABVDF123$";
            bool expected = false;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_PasswordWithoutUpperSymbol()
        {
            //Arrange
            string password = "asdfg123$";
            bool expected = false;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Check_PasswordWithoutSpecialSymbol()
        {
            //Arrange

            string password = "Asdfg1234";
            bool expected = false;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

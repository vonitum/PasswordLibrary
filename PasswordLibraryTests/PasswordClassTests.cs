using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordLibrary;
using System;
namespace PasswordLibraryTests
{
    [TestClass]
    public class PasswordClassTests
    {
        [TestMethod]
        public void CheckPassword_ValidPassword_ReturnsTrue()
        { 
                PasswordClass passwordClass = new PasswordClass();
                bool result = passwordClass.CheckPassword("12HTkk^$@5");
                Assert.IsTrue(result);
            
        }
        [TestMethod]
        public void CheckPassword_MaxTruePassword_ReturnsTrue()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("abVGH$@5abVGH$@");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckPassword_MinTruePassword_ReturnsTrue()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("abVGH$@5");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckPassword_Empty_ReturnsFalse()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckPassword_lessrange_ReturnsFalse()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("1dK$");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckPassword_onlyLower_ReturnsFalse()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("strokasymb");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckPassword_onlyUpper_ReturnsFalse()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("SDLUTRHHNMH");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckPassword_onlynumber_ReturnsFalse()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("12341236401");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckPassword_onlysymbol_ReturnsFalse()
        {
            PasswordClass passwordClass = new PasswordClass();
            bool result = passwordClass.CheckPassword("$$$$$()&*^%@@");
            Assert.IsFalse(result);
        }
      


    }
}

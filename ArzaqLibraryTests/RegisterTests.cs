using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArzaqLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary.Tests
{
    [TestClass]
    public class RegisterTests
    {
        [TestMethod]
        public void RegisterUser_ValidInput_Success()
        {
            // Arrange
            string username = "arzaq";
            string password = "123";
            string confirmPassword = "123";
            string email = "arzaq@gmail.com";
            Register<string> register = new Register<string>(username, password, confirmPassword, email);
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            register.RegisterUser();
            string result = sw.ToString().Trim();

            // Assert
            string expected = $"User registered successfully.\r\nUsername: {username}\r\nEmail: {email}";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RegisterUser_EmptyInput_Fail()
        {
            // Arrange
            string username = "";
            string password = "";
            string confirmPassword = "";
            string email = "";
            Register<string> register = new Register<string>(username, password, confirmPassword, email);
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            register.RegisterUser();
            string result = sw.ToString().Trim();

            // Assert
            string expected = "Please fill in all fields.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RegisterUser_PasswordNotMatch_Fail()
        {
            // Arrange
            string username = "arzaq";
            string password = "123";
            string confirmPassword = "1234";
            string email = "arzaq@gmail.com";
            Register<string> register = new Register<string>(username, password, confirmPassword, email);
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            register.RegisterUser();
            string result = sw.ToString().Trim();

            // Assert
            string expected = "Passwords do not match.";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RegisterUser_InvalidEmail_Fail()
        {
            // Arrange
            string username = "arzaq";
            string password = "123";
            string confirmPassword = "123";
            string email = "arzaqgmail.com";
            Register<string> register = new Register<string>(username, password, confirmPassword, email);
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            register.RegisterUser();
            string result = sw.ToString().Trim();

            // Assert
            string expected = "Invalid email address.";
            Assert.AreEqual(expected, result);
        }
    }

}

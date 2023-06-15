using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using NUnit.Framework;

namespace LoginAccount.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginAccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            // Precondition
            Contract.Requires(!string.IsNullOrEmpty(login.Username), "Username: Username tidak boleh null atau kosong");
            Contract.Requires(!string.IsNullOrEmpty(login.Password), "Password: Password tidak boleh null atau kosong");

            // Memeriksa apakah username dan password sesuai
            if (login.Username == "username" && login.Password == "1234")
            {
                // Postcondition
                Contract.Ensures(Contract.Result<IActionResult>() != null, "Hasil tidak boleh null");

                return Ok("Login berhasil");
            }
            else
            {
                // Postcondition
                Contract.Ensures(Contract.Result<IActionResult>() != null, "Hasil tidak boleh null");

                return BadRequest("Login gagal");
            }
        }
    }

    [TestFixture]
    public class LoginAccountControllerTests
    {
        [Test]
        public void Login_ValidCredentials_ReturnsOkResult()
        {
            // Arrange
            var loginApi = new LoginAccountController();
            var loginModel = new LoginModel
            {
                Username = "username",
                Password = "1234"
            };

            // Act
            var result = loginApi.Login(loginModel) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Login berhasil", result.Value);
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsBadRequestResult()
        {
            // Arrange
            var loginApi = new LoginAccountController();
            var loginModel = new LoginModel
            {
                Username = "invalid",
                Password = "1234"
            };

            // Act
            var result = loginApi.Login(loginModel) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Login gagal", result.Value);
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

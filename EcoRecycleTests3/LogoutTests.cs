using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUBES_KPL_2023;

namespace TUBES_KPL_2023_UnitTest
{
    [TestClass]
    public class LogoutTest
    {
        public object Assert { get; private set; }

        [TestMethod]
        public void TestLogout()
        {
            Logout logout = new Logout();

            // Test State Idle
            logout.ProcessInput("random_input");
            Assert.AreEqual(Logout.State.Idle, logout.currentState);

            logout.ProcessInput("logout");
            Assert.AreEqual(Logout.State.Confirming, logout.currentState);

            // Test State Confirming
            logout.ProcessInput("tidak");
            Assert.AreEqual(Logout.State.Idle, logout.currentState);

            logout.ProcessInput("iya");
            Assert.AreEqual(Logout.State.LoggingOut, logout.currentState);

            // Test State LoggingOut
            logout.ProcessInput("random_input");
            Assert.AreEqual(Logout.State.LoggingOut, logout.currentState);
        }
    }
}

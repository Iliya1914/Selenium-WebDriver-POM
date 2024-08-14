using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Tests
{
    public class HiddenMenuTests : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickMenuButton();

            Assert.That(hiddenMenuPage.IsMenuOpen(), Is.True, "The hidden menu was not open.");
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickMenuButton();

            hiddenMenuPage.ClickLogoutButton();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"), "The user could not logged out.");
        }
    }
}

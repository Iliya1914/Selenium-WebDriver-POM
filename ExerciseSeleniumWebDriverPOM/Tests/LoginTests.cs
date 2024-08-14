using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void TestLoginWithValidCredentials()
        {
            Login("standard_user", "secret_sauce");

            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "The Inventory page was not loaded after successful login.");
        }

        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            Login("standard", "secret_");

            Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "The error message is not correct.");
        }

        [Test]
        public void TestLoginWithLockedOutUser()
        {
            Login("locked_out_user", "secret_sauce");

            Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."), "The error message for locked_out_user is not correct.");
        }
    }
}

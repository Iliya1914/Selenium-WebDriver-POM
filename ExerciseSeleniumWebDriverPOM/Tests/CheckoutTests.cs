using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Tests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByIndex(4);

            inventoryPage.ClickCartLink();

            cartPage.ClickCheckout();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.That(checkoutPage.IsPageLoaded(), Is.True, "The Checkout page was not loaded.");
        }

        [Test]
        public void TestContinueToNextStep() 
        {
            checkoutPage.EnterFirstName("Levski");

            checkoutPage.EnterLastName("Sofia");

            checkoutPage.EnterPostalCode("1914");

            checkoutPage.ClickContinue();

            Assert.That(driver.Url.Contains("checkout-step-two.html"), "The user was not redirected to the next step in the checkout process.");
        }

        [Test]
        public void TestCompleteOrder()
        {
            checkoutPage.EnterFirstName("Levski");

            checkoutPage.EnterLastName("Sofia");

            checkoutPage.EnterPostalCode("1914");

            checkoutPage.ClickContinue();

            checkoutPage.ClickFinish();

            Assert.That(checkoutPage.IsCheckoutComplete(), Is.True, "The order was not completed.");
        }
    }
}

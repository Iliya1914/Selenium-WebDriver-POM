using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Tests
{
    public class CartTests : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByIndex(4);

            inventoryPage.ClickCartLink();

        }

        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "The item was not displayed in the cart.");
        }

        [Test]
        public void TestClickCheckout() 
        {
            cartPage.ClickCheckout();
            Assert.That(checkoutPage.IsPageLoaded(), Is.True, "The Checkout page was not loaded.");
        }
    }
}

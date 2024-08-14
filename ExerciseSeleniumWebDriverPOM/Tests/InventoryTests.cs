using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Tests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public new void SetUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestInventoryItemsAreDispled() 
        { 
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "The items are not displayed in the Inventory page.");
        }

        [Test]
        public void TestAddToCartByIndex() 
        {
            inventoryPage.AddToCartByIndex(4);

            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "The item was not added to the cart by index.");
        }

        [Test]
        public void TestAddToCartByName()
        {
            inventoryPage.AddToCartByName("Sauce Labs Fleece Jacket");

            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True, "The item was not added to the cart by name.");
        }

        [Test]
        public void TestPageTitle()
        {
            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "The title of the Inventory page is not correct.");
        }
    }
}

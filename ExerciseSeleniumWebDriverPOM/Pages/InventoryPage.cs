using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Pages
{
    public class InventoryPage : BasePage
    {
        protected readonly By cartLink = By.XPath("//a[@data-test = 'shopping-cart-link']");

        protected readonly By productsTitle = By.XPath("//span[@data-test = 'title']");

        protected readonly By inventoryItems = By.XPath("//div[@class = 'inventory_item']");

        public InventoryPage(IWebDriver driver) : base(driver)
        {
        }

        public void AddToCartByIndex(int itemIndex)
        {
            var itemAddToCartButton = By.XPath($"//div[@class = 'inventory_item'][{itemIndex}]//button");
            Click(itemAddToCartButton);
        }

        public void AddToCartByName(string productName) 
        {
            var itemAddToCartButton = By.XPath($"//div[text()= '{productName}']/ancestor::div[@class = 'inventory_item']//button");
            Click(itemAddToCartButton);
        }

        public void ClickCartLink()
        {
            Click(cartLink);
        }

        public bool IsInventoryDisplayed()
        {
            return FindElements(inventoryItems).Any();
        }

        public bool IsPageLoaded() 
        {
            return GetText(productsTitle).Contains("Products") && driver.Url.Contains("inventory.html");
        }
    }
}

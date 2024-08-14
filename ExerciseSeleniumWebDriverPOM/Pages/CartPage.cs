using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Pages
{
    public class CartPage : BasePage
    {
        protected readonly By cartItem = By.XPath("//div[@class = 'cart_item']");

        protected readonly By checkoutButton = By.XPath("//button[@id= 'checkout']");
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsCartItemDisplayed()
        {
            return FindElement(cartItem).Displayed;
        }

        public void ClickCheckout()
        {
            Click(checkoutButton);
        }
    }
}

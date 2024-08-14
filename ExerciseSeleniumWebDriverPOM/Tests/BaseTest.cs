using ExerciseSeleniumWebDriverPOM.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected LoginPage loginPage;

        protected InventoryPage inventoryPage;

        protected CartPage cartPage;

        protected CheckoutPage checkoutPage;

        protected HiddenMenuPage hiddenMenuPage;

        [SetUp]
        public void SetUp()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            loginPage = new LoginPage(driver);

            inventoryPage = new InventoryPage(driver);

            cartPage = new CartPage(driver);

            checkoutPage = new CheckoutPage(driver);

            hiddenMenuPage = new HiddenMenuPage(driver);
        }

        [TearDown]
        public void TearDown() 
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        public void Login(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            loginPage.InputUsername(username);
            loginPage.InputPassword(password);
            loginPage.ClickLoginButton();
        }
    }
}

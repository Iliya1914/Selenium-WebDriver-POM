using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Pages
{
    public class CheckoutPage : BasePage
    {
        protected readonly By firstNameField = By.XPath("//input[@id= 'first-name']");

        protected readonly By lastNameField = By.XPath("//input[@id= 'last-name']");

        protected readonly By postalCodeField = By.XPath("//input[@id= 'postal-code']");

        protected readonly By continueButton = By.XPath("//input[@id= 'continue']");

        protected readonly By finishButton = By.XPath("//button[@id= 'finish']");

        protected readonly By completeHeader = By.XPath("//h2[@class= 'complete-header']");
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterFirstName(string firstName)
        {
            Type(firstNameField, firstName);
        }

        public void EnterLastName(string lastName)
        {
            Type(lastNameField, lastName);
        }

        public void EnterPostalCode(string postalCode)
        {
            Type(postalCodeField, postalCode);
        }

        public void ClickContinue()
        {
            Click(continueButton);
        }

        public void ClickFinish() 
        {
            Click(finishButton);
        }

        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") ||
                   driver.Url.Contains("checkout-step-two.html");
        }

        public bool IsCheckoutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }
    }
}

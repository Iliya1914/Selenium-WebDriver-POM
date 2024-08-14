using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeleniumWebDriverPOM.Pages
{
    public class LoginPage : BasePage
    {
        protected readonly By usernameField = By.XPath("//input[@data-test = 'username']");

        protected readonly By passwordField = By.XPath("//input[@data-test = 'password']");

        protected readonly By loginButton = By.XPath("//input[@type = 'submit']");

        protected readonly By errorMessage = By.XPath("//h3[@data-test = 'error']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void InputUsername(string username)
        {
            Type(usernameField, username);
        }

        public void InputPassword(string password)
        {
            Type(passwordField, password);
        }

        public void ClickLoginButton() 
        {
            Click(loginButton);
        }

        public string GetErrorMessage()
        {
            return GetText(errorMessage);
        }
    }
}

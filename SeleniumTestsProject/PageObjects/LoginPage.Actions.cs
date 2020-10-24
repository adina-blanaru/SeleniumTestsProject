using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsProject.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void AuthenticateUser(string user, string password)
        {
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.SendKeys(password);
            SubmitButton.Click();
        }

        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);            
        }

        public void VerifyElementContainsText(IWebElement elementToVerify, string text)
        {
            Assert.IsTrue(elementToVerify.Text.Contains(text));
        }

    }
}

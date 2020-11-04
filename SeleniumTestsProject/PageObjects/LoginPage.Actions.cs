using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestsProject.Dto;
using System;
using System.Reflection;

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

        public void LoginIntoApplication(UserDto user)
        {
            //EmailFieldTextBox.SendKeys(user.userEmail);
            //PasswordFieldTextBox.SendKeys(user.userPassword);

            //var validUser = user.GetValidUser();
            //var userRuntimeProperties = user.GetType().GetRuntimeProperties(); //returns a collection
            //var userProperties = user.GetType().GetProperties(); //returns an array
            
            var emailValue = user.GetType().GetRuntimeProperty("userEmail").GetValue(user);
            if (emailValue != null)
            {
                EmailFieldTextBox.SendKeys(emailValue.ToString());
            }

            var passwordValue = user.GetType().GetRuntimeProperty("userPassword").GetValue(user);
            if (passwordValue != null)
            {
                PasswordFieldTextBox.SendKeys(passwordValue.ToString());
            }

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

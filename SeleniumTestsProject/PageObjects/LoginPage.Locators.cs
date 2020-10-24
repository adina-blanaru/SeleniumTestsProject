using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTestsProject.PageObjects
{
    partial class LoginPage
    {
        private IWebElement EmailFieldTextBox => 
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[type=email]")));
        private IWebElement PasswordFieldTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));
        private IWebElement SubmitButton => _driver.FindElement(By.CssSelector("button[type=submit]"));
        public IWebElement AlertMessage => _driver.FindElement(By.ClassName("alert"));
    }
}

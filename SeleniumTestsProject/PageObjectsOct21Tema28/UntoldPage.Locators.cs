using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class UntoldPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public UntoldPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public IWebElement UntoldRadio =>
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("styles-module--top--31tR1")));
        public IWebElement MenuButton => _driver.FindElement(By.CssSelector(".bm-burger-button button"));
        public IWebElement HomeMenuItem => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='HOME']")));
    }
}

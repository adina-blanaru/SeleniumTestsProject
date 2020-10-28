using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTestsProject.PageObjects
{
    partial class ProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void AdaugaInCos()
        {
            AdaugaInCosButton.Click();
        }
    }
}

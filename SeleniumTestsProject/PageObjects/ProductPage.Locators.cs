using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTestsProject.PageObjects
{
    partial class ProductPage
    {
        private IWebElement AdaugaInCosButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn-primary")));

    }
}

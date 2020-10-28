using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTestsProject.PageObjects
{
    partial class ProductPage
    {
        private IWebElement AdaugaInCosButton => _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".btn-primary")));

    }
}

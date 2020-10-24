using OpenQA.Selenium;

namespace SeleniumTestsProject
{
    partial class CartPage
    {
        private IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ComandaAcumButton => _driver.FindElement(By.ClassName("btn-danger"));

    }
}
using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjects
{
    class BasePage : BaseDriver
    {
        public readonly string CasqadUrl = "http://demosite.casqad.org/";
        private IWebDriver _driver;
        
        public BasePage()
        {
            _driver = Driver;
        }

        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}

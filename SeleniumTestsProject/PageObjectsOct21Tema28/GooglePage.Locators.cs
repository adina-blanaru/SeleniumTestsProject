using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class GooglePage : BaseDriver
    {
        private IWebDriver _driver;

        public GooglePage()
        {
            _driver = Driver;
        }

        //consent dialog
        private IWebElement ConsentIframe => _driver.FindElement(By.CssSelector("iframe"));
        private IWebElement AgreeButton => _driver.FindElement(By.Id("introAgreeButton"));
        //home page
        private IWebElement SearchFieldTextBox => _driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
        private IWebElement GoogleSearchButton => _driver.FindElement(By.ClassName("gNO89b"));
        //results page
        private IWebElement ImagesLink => _driver.FindElement(By.CssSelector(".hdtb-mitem.hdtb-imb a"));
        private IWebElement FirstImage => _driver.FindElement(By.XPath("//div[1]/a[@jsname='sTFXNd']"));
        private IWebElement BackToImagesIcon => _driver.FindElement(By.ClassName("IA8gLe"));
        private IWebElement ImagePanel => _driver.FindElement(By.Id("islsp"));
    }
}
using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjects
{
    partial class SignUpPage
    {
        private IWebDriver _driver;

        public SignUpPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement NumeField => _driver.FindElement(By.XPath("//input[@name='name']"));
        public IWebElement EmailField => _driver.FindElement(By.XPath("//input[@name='email']"));
        public IWebElement TelefonField => _driver.FindElement(By.XPath("//input[@name='phone']"));
        public IWebElement AdresaField => _driver.FindElement(By.XPath("//textarea[@name='address']"));
        public IWebElement ParolaField => _driver.FindElement(By.XPath("//input[@name='password_1']"));
        public IWebElement RepetaParolaField => _driver.FindElement(By.XPath("//input[@name='password_2']"));
        public IWebElement InscriereButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
    }
}

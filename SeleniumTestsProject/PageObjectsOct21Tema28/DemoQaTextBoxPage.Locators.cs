using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class DemoQaTextBoxPage
    {
        private IWebDriver _driver;
        public DemoQaTextBoxPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement FullNameFieldTextBox => _driver.FindElement(By.Id("userName"));
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.Id("userEmail"));
        private IWebElement CurrentAddressFieldTextBox => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement PermanentAddressFieldTextBox => _driver.FindElement(By.Id("permanentAddress"));
        private IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement ConfirmationPanel => _driver.FindElement(By.Id("output"));
    }
}

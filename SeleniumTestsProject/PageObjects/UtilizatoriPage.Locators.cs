using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjects
{
    partial class UtilizatoriPage
    {
        private IWebDriver _driver;

        public UtilizatoriPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UsersTableHeader => _driver.FindElement(By.XPath("//thead"));
        private IWebElement EditIcon => _driver.FindElement(By.ClassName("fa-pencil"));

        //Actualizeaza Utilizator page
        public IWebElement SubmitButton => _driver.FindElement(By.ClassName("btn-primary"));
    }
}

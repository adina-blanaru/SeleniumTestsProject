
using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjects
{
    partial class UtilizatoriPage
    {
        public void EditUser()
        {
            EditIcon.Click();
        }

        public void EditUser(string adinaUser)
        {
            GetUserRowElement(adinaUser).FindElement(By.ClassName("fa-pencil")).Click();
        }

        private IWebElement GetUserRowElement(string email)
        {
            return _driver.FindElement(By.XPath($"//tr/td[3][text()='{email}']/parent::tr"));
        }
    }
}

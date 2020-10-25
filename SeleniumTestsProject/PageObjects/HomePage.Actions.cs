
using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjects
{
    partial class HomePage
    {
        public void GoToAuthentication()
        {
            AutentificareButton.Click();
        }

        public void GoToSignUp()
        {
            InscriereButton.Click();
        }

        public void DisconnectUser()
        {
            DeconectareButton.Click();
        }

        public void VeziDetaliiProdus()
        {
            VeziDetaliiButton.Click();
        }

        public void GoToMenu(string menuName)
        {
            GetMenuElement(menuName).Click();
        }

        public IWebElement GetMenuElement(string menuName)
        {
            return NavBar.FindElement(By.XPath($"//a[contains(text(),'{menuName}')]"));
        }
    }
}

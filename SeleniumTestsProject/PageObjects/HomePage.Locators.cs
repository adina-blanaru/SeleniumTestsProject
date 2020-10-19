using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsProject.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //css selectors are a bit faster than xpath
        //css cannot get element by text, cannot go back in the dom
        public IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));


        //pagina de autentificare
        //public IWebElement EmailField => _driver.FindElement(By.XPath("//input[@type='email']"));
        //public IWebElement PasswordField => _driver.FindElement(By.XPath("//input[@type='password']"));
        //public IWebElement AutentificareButton => _driver.FindElement(By.XPath("//button[@type='submit']"));


    }
}

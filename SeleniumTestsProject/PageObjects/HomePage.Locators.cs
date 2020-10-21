﻿using OpenQA.Selenium;

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
        private IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement VeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));

    }
}

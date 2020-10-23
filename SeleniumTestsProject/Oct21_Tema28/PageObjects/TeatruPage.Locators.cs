﻿
using OpenQA.Selenium;

namespace SeleniumTestsProject.Oct21_Tema28.PageObjects
{
    partial class TeatruPage
    {
        private IWebDriver _driver;
        public TeatruPage(IWebDriver driver)
        {
            _driver = driver;

        }

        public IWebElement TeamMenu => _driver.FindElement(By.XPath("//span[(text()='Team')]"));
        public IWebElement FirstActor => _driver.FindElement(By.Id("av-masonry-1-item-2697"));
        //private IWebElement FirstActor => _driver.FindElement(By.XPath("//a[starts-with(@id,'av-masonry-1-item-')][1]"));
        public IWebElement FirstShow => _driver.FindElement(By.XPath("//div/p/a/strong[contains(text(),'Prins în plasă')]"));
        public IWebElement CumparaBiletButton => _driver.FindElement(By.XPath("//span[text()='CUMPARA BILET']"));
    }
}

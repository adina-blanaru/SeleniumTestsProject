using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject
{
    public class BeforeAfter
    {
        private IWebDriver _driver;
        public IWebDriver Driver { get => _driver; set => _driver = value; }

        [BeforeScenario()]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}

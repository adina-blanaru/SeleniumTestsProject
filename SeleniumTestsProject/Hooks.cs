using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestsProject
{
    public class Hooks
    {
        protected IWebDriver Driver;

        [SetUp] //runs before each test
        //[OneTimeSetUp]    //runs one time before all tests
        public void Setup()
        {
            Driver = new ChromeDriver();    //create new instance of chromdriver
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Driver.Manage().Window.Maximize();  //maximize window
            //Driver.Navigate().GoToUrl("http://demosite.casqad.org/");

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        public void NavigateToUrl(string pageUrl)
        {
            Driver.Navigate().GoToUrl(pageUrl);
        }

        public void scrollElementIntoView(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }


    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumTestsProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject
{
    //public enum BrowserType
    //{
    //    Chrome,
    //    Firefox
    //}

    [Binding]  //otherwise it creates 2 browser instances
    public class Hooks : BaseDriver
    {
        //private BrowserType _browserType;
        //protected static IWebDriver Driver;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            CreateDriver();
        //    var browserType = TestContext.Parameters.Get("Browser", "Chrome");
        //    _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
        //    if (Driver is null)
        //    {
        //        ChooseDriverInstance(_browserType);
        //        Driver.Manage().Window.Maximize();
        //    }
        //    //Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        //}

        //public void ChooseDriverInstance(BrowserType browserType)
        //{
        //    switch (browserType)
        //    {
        //        case BrowserType.Chrome:
        //            Driver = new ChromeDriver();
        //            break;
        //        case BrowserType.Firefox:
        //            Driver = new FirefoxDriver();
        //            break;
        //    }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //if (!(Driver is null))
            {
                Driver.Quit();
                //Driver = null;
            }
        }
    }
}

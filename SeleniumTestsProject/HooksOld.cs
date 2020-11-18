using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumTestsProject.TestData;
using System;
using System.Linq;

namespace SeleniumTestsProject
{
    public enum BrowserTypeOld
    { 
        Chrome,
        Firefox
    }
    
    public class HooksOld
    {
        private BrowserType _browserType;
        protected IWebDriver Driver;
        protected MyTestData TestObject;

        [SetUp] //runs before each test
        //[OneTimeSetUp]    //runs one time before all tests
        public void Setup()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Chrome"); //default value if not specified when running the test from command line  
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType); //(BrowserType) cast to BrowserType
            ChooseDriverInstance(_browserType);

            //Driver = new ChromeDriver();    //create new instance of chromdriver
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Driver.Manage().Window.Maximize();  //maximize window
            //Driver.Navigate().GoToUrl("http://demosite.casqad.org/");

            TestObject = MyTestData.LoadTestDataFromFile()
                .First(obj => obj.TestCaseName == TestContext.CurrentContext.Test.MethodName);
        }

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
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

    }
}

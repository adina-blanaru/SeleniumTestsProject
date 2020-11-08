using OpenQA.Selenium;
using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {

        [Given(@"I go to the '(.*)' website")]
        public void GivenIGoToTheWebsite(string siteUrl)
        {
            BasePage basePage = new BasePage();
            basePage.NavigateToUrl(siteUrl);
        }

    }
}

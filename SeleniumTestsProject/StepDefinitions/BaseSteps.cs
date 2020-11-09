using OpenQA.Selenium;
using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public class BaseSteps : Hooks
    {

        [Given(@"I go to the '(.*)' website")]
        public void GivenIGoToTheWebsite(string siteUrl)
        {
            BasePage basePage = new BasePage(Driver);
            basePage.NavigateToUrl(siteUrl);
        }

    }
}

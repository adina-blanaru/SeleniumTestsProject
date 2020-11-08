using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestsProject.PageObjects;
using SeleniumTestsProject.PageObjectsOct21Tema28;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {
        [Given(@"I go to Google website")]
        public void GivenIGoToGoogleWebsite()
        {
            BasePage basePage = new BasePage();
            GooglePage googlePage = new GooglePage();

            basePage.NavigateToUrl("https://www.google.com/");
            googlePage.AcceptTerms();
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string searchText)
        {
            GooglePage googlePage = new GooglePage();
            googlePage.GoogleSearch(searchText);
        }

        [Then(@"I should be able to expand the first image")]
        public void ThenIShouldBeAbleToExpandTheFirstImage()
        {
            GooglePage googlePage = new GooglePage();
            googlePage.ClickFirstResultFromImages();
            Assert.IsTrue(googlePage.IsImagePanelDisplayed());
        }

        [Then(@"Return to the results page")]
        public void ThenReturnToTheResultsPage()
        {
            GooglePage googlePage = new GooglePage();
            googlePage.ReturnToImages();
            Assert.IsFalse(googlePage.IsImagePanelDisplayed());
        }

    }
}

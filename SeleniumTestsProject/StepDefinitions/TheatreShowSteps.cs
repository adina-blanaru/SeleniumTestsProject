using NUnit.Framework;
using SeleniumTestsProject.PageObjects;
using SeleniumTestsProject.PageObjectsOct21Tema28;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class TheatreShowSteps : Hooks
    {
        [When(@"I go to the first actor page")]
        public void WhenIGoToTheFirstActorPage()
        {
            TeatruPage teatruPage = new TeatruPage(Driver);
            teatruPage.TeamMenu.Click();
            Helper.ClickWithScroll(Driver, teatruPage.FirstActor);
        }

        [When(@"I choose the first show")]
        public void WhenIChooseTheFirstShow()
        {
            TeatruPage teatruPage = new TeatruPage(Driver);
            Helper.ClickWithScroll(Driver, teatruPage.FirstShow);
        }

        [Then(@"I should have the option to buy a ticket")]
        public void ThenIShouldHaveTheOptionToBuyATicket()
        {
            TeatruPage teatruPage = new TeatruPage(Driver);
            Assert.IsTrue(teatruPage.CumparaBiletButton.Displayed);
        }

    }
}

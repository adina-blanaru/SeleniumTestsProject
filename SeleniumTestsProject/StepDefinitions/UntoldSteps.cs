using NUnit.Framework;
using SeleniumTestsProject.PageObjects.Misc;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class UntoldSteps : Hooks
    {
        [When(@"I go to home page from the navigation menu")]
        public void WhenIGoToHomePageFromTheNavigationMenu()
        {
            UntoldPage untoldPage = new UntoldPage(Driver);
            var a = untoldPage.UntoldRadio.Displayed;  //workaround to wait for UntoldRadio to be displayed
            untoldPage.MenuButton.Click();
            untoldPage.HomeMenuItem.Click();
        }

        [Then(@"I should see the home page")]
        public void ThenIShouldSeeTheHomePage()
        {
            Assert.AreEqual("https://untold.com/", Driver.Url);
        }

    }
}

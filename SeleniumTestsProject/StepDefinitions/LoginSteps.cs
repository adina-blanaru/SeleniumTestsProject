using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps:BeforeAfter
    {
        [Given(@"I'm on the login page")]
        public void GivenIMOnTheLoginPage()
        {
            HomePage homePage = new HomePage(Driver);
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            homePage.GoToAuthentication();
        }

        [When(@"I login with email (.*) and password (.*)")]
        public void WhenILoginAsAdmin(string email, string password)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser(email, password);
        }

        [Then(@"I should see the Deconectare button")]
        public void ThenIShouldSeeTheDeconectareButton()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
        }

        [When(@"I logout of the site")]
        public void WhenILogoutOfTheSite()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.DisconnectUser();
        }

        [Then(@"I should see the login page")]
        public void ThenIShouldSeeTheLoginPage()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.AutentificareButton);
        }

    }
}

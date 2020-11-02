using NUnit.Framework;
using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]  //specflow argument - indicates that this class is binded with a feature file
    public sealed class AuthenticationStepDefinitions:Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AuthenticationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I login with valid user")]
        public void GivenILoginWithValidUser()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAuthentication();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        }

    }
}

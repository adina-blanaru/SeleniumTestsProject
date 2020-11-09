using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class AdministrationSteps : Hooks
    {
        [Then(@"I see the users list")]
        public void ThenISeeTheUsersList()
        {
            LoginPage loginPage = new LoginPage(Driver);
            UtilizatoriPage utilizatoriPage = new UtilizatoriPage(Driver);
            loginPage.VerifyElementContainsText(utilizatoriPage.UsersTableHeader, "Email");
        }

        [When(@"I edit the user '(.*)'")]
        public void WhenIEditTheUser(string userEmail)
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            UtilizatoriPage utilizatoriPage = new UtilizatoriPage(Driver);
            utilizatoriPage.ClickEditUser(userEmail);  //edit specific user
            signUpPage.FillInEmailField("edited@test.com");
            utilizatoriPage.ClickActualizeazaUtilizator();
            //Change email back to initial value
            signUpPage.FillInEmailField(userEmail);
            utilizatoriPage.ClickActualizeazaUtilizator();
        }

        [Then(@"The user should be updated")]
        public void ThenTheUserShouldBeUpdated()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "The user has been successfully updated.");
        }




    }
}

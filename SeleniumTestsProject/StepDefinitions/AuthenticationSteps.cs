using NUnit.Framework;
using SeleniumTestsProject.Dto;
using SeleniumTestsProject.PageObjects;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]  //specflow attribute - indicates that this class is binded with a feature file
    public sealed class AuthenticationSteps : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AuthenticationSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //[When(@"I login with user '(.*)'")]
        //public void WhenILoginWithUser(string userEmailAddress)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.EmailFieldTextBox.SendKeys(userEmailAddress);
        //}

        //[When(@"password '(.*)'")]
        //public void WhenPassword(string userPassword)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.PasswordFieldTextBox.SendKeys(userPassword);
        //    loginPage.SubmitButton.Click();
        //}

        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(Driver);
            //loginPage.AuthenticateUser(myUser.userEmail, myUser.userPassword);
            loginPage.LoginIntoApplication(myUser);
        }


        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }

        [Given(@"I am logged in as (admin|my demo user)")]
        public void GivenIAmLoggedInAs(string UserType)
        {
            BasePage basePage = new BasePage(Driver);
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            basePage.NavigateToUrl(basePage.CasqadUrl);
            homePage.GoToAuthentication();

            if (UserType.Equals("admin"))
                loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            else if (UserType.Equals("my demo user"))
                loginPage.AuthenticateUser("ad_demo@test.com", "demo123?");
        }

        [When(@"I fill in the sign up form")]
        public void WhenIFillInTheSignUpForm(Table table)
        {
            var myUser = table.CreateInstance<UserInfoDto>();
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.CreateAccountDto(myUser);
        }

        [Then(@"My account is created")]
        public void ThenMyAccountIsCreated()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Your account was created, now you can login.");
        }

        [Then(@"I can login with credentials")]
        public void ThenICanLoginWithCredentials(Table table)
        {
            var myUser = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
        }


        [When(@"I log out")]
        public void WhenILogOut()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.DisconnectUser();
        }

        [Then(@"I am logged out")]
        public void ThenIAmLoggedOut()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.AutentificareButton);
        }




    }
}

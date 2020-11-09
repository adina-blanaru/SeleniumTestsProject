using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class NavigationSteps : Hooks
    {
        [Given(@"I navigate to home page")]
        public void GivenINavigateToHomePage()
        {
            BasePage basePage = new BasePage(Driver);
            basePage.NavigateToUrl(basePage.CasqadUrl);
        }

        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            BasePage basePage = new BasePage(Driver);
            HomePage homePage = new HomePage(Driver);
            basePage.NavigateToUrl(basePage.CasqadUrl);
            homePage.GoToAuthentication();
        }

        [Given(@"I navigate to sign up page")]
        public void GivenINavigateToSignUpPage()
        {
            BasePage basePage = new BasePage(Driver);
            HomePage homePage = new HomePage(Driver);
            basePage.NavigateToUrl(basePage.CasqadUrl);
            homePage.GoToSignUp();
        }

        [Then(@"I should be able to access all the menus")]
        public void ThenIShouldBeAbleToAccessAllTheMenus()
        {
            string[] menus = { "Laptopuri", "Telefoane", "Foto", "Carti", "Accesorii" };

            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            foreach (var menu in menus)
            {
                homePage.GoToMenu(menu);
                loginPage.VerifyElementContainsText(homePage.CategoryLabel, menu);
            }
        }
        //----------------------------------------------------------------------------

        [When(@"I navigate to Administration page")]
        public void WhenINavigateToAdministrationPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToMenu("Administrare");
        }

        [Then(@"I see the Site menu")]
        public void ThenISeeTheSiteMenu()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(homePage.GetMenuElement("Site"));
        }

        [When(@"I go to Users page in the Administration section")]
        public void WhenIGoToUsersPageInTheAdministrationSection()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToMenu("Administrare");
            homePage.GoToMenu("Utilizatori");
        }

    }
}

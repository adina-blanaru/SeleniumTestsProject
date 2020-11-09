using SeleniumTestsProject.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class CartSteps : Hooks
    {
        [When(@"I add a product to the cart")]
        public void WhenIAddAProductToTheCart()
        {
            HomePage homePage = new HomePage(Driver);
            ProductPage productPage = new ProductPage(Driver);
            homePage.VeziDetaliiProdus();
            productPage.AdaugaInCos();
        }

        [Then(@"I need to login to complete the action")]
        public void ThenINeedToLoginToCompleteTheAction()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Pentru a efectua aceasta actiune, va rugam sa va autentificati");
        }

        [Then(@"I see the order button in my cart")]
        public void ThenISeeTheOrderButtonInMyCart()
        {
            CartPage cartPage = new CartPage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(cartPage.ComandaAcumButton);
        }

    }
}


namespace SeleniumTestsProject.PageObjects
{
    partial class HomePage
    {
        public void GoToAuthentication()
        {
            AutentificareButton.Click();
        }

        public void GoToSignUp()
        {
            InscriereButton.Click();
        }

        public void DisconnectUser()
        {
            DeconectareButton.Click();
        }

        public void VeziDetaliiProdus()
        {
            VeziDetaliiButton.Click();
        }
    }
}

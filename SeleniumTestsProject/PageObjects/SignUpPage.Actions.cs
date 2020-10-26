
namespace SeleniumTestsProject.PageObjects
{
    partial class SignUpPage
    {
        public void CreateAccount(string email, string password)
        {
            NumeField.Click();
            NumeField.SendKeys("AD Demo User");
            EmailField.SendKeys(email);
            TelefonField.SendKeys("0744123456");            
            AdresaField.SendKeys("Strada mea, Brasov, Romania");
            ParolaField.SendKeys(password);
            RepetaParolaField.SendKeys("demo123?");
            InscriereButton.Click();
        }

        public void FillInEmailField(string email)
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }
    }
}

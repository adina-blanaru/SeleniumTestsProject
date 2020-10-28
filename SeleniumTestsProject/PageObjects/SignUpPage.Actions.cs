
namespace SeleniumTestsProject.PageObjects
{
    partial class SignUpPage
    {
        public void CreateAccount(string nume, string email, string telefon, string adresa, string password)
        {
            NumeField.Click();
            NumeField.SendKeys(nume);
            EmailField.SendKeys(email);
            TelefonField.SendKeys(telefon);            
            AdresaField.SendKeys(adresa);
            ParolaField.SendKeys(password);
            RepetaParolaField.SendKeys(password);
            InscriereButton.Click();
        }

        public void FillInEmailField(string email)
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }
    }
}

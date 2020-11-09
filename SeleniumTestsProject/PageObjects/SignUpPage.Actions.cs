
using SeleniumTestsProject.Dto;
using System.Reflection;
using System.Threading;

namespace SeleniumTestsProject.PageObjects
{
    partial class SignUpPage
    {
        public static string NewUniqueEmail = "";
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

        public void CreateAccountDto(UserInfoDto user)
        {
            var NameValue = user.GetType().GetRuntimeProperty("Name").GetValue(user);
            if (NameValue != null)
            {
                NumeField.Click();
                NumeField.SendKeys(NameValue.ToString());
            }

            var EmailValue = user.GetType().GetRuntimeProperty("Email").GetValue(user);
            if (EmailValue != null)
            {
                if (EmailValue.Equals("NewUniqueEmail"))
                {
                    string Timestamp = System.DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss");
                    NewUniqueEmail = $"AD_{Timestamp}@test.com";
                    EmailField.SendKeys(NewUniqueEmail);
                } 
                else 
                {
                    EmailField.SendKeys(EmailValue.ToString());
                }
            }

            var PhoneValue = user.GetType().GetRuntimeProperty("Phone").GetValue(user);
            if (PhoneValue != null)
            {
                TelefonField.SendKeys(PhoneValue.ToString());
            }

            var AddressValue = user.GetType().GetRuntimeProperty("Address").GetValue(user);
            if (AddressValue != null)
            {
                AdresaField.SendKeys(AddressValue.ToString());
            }

            var PasswordValue = user.GetType().GetRuntimeProperty("Password").GetValue(user);
            if (PasswordValue != null)
            {
                ParolaField.SendKeys(PasswordValue.ToString());
                RepetaParolaField.SendKeys(PasswordValue.ToString());
            }

            InscriereButton.Click();
        }

        public void FillInEmailField(string email)
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }
    }
}

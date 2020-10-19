using System.Threading;

namespace SeleniumTestsProject.PageObjects
{
    partial class InscrierePage
    {
        public void CreateAccount()
        {
            NumeField.SendKeys("AD Demo User");
            EmailField.SendKeys("ad_demo@test.com");
            TelefonField.SendKeys("0744123456");
            AdresaField.SendKeys("Strada mea, Brasov, Romania");
            ParolaField.SendKeys("demo123?");
            RepetaParolaField.SendKeys("demo123?");
            //InscriereButton.Click();
        }

    }
}

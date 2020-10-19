using NUnit.Framework;
using SeleniumTestsProject.PageObjects;
using System.Threading;

namespace SeleniumTestsProject
{
    [TestFixture]   //marks the class as a tests class
    class Tests:Hooks
    {
        [Test]  //marks the method as a test
        public void Autentificare()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AutentificareButton.Click();
            
            Thread.Sleep(1000);
        }

        [Test]
        public void Inscriere()
        {
            HomePage homePage = new HomePage(Driver);
            InscrierePage inscrierePage = new InscrierePage(Driver);

            homePage.InscriereButton.Click();
            inscrierePage.CreateAccount();

            Thread.Sleep(1000);
        }

        [Test]
        public void MyThirdTest()
        {
            Thread.Sleep(1000);
        }

    }
}

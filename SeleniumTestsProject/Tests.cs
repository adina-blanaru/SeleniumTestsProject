using NUnit.Framework;
using SeleniumTestsProject.PageObjects;
using System.Threading;

namespace SeleniumTestsProject
{
    [TestFixture]   //marks the class as a tests class
    class Tests:Hooks
    {
        //nunit3-console.exe "C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\Unit Test Project\SeleniumTestsProject\SeleniumTestsProject\bin\Debug\SeleniumTestsProject.dll" --where "cat==myCat"

        [Test, Category("Login")]  //marks the method as a test; category can be added on test or on test fixture
        public void ValidateLoginIntoApplicationWithValidCredentials()
        {
            //Arrange
            NavigateToUrl("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();

            //Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");

            //Assert
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
            //Assert.IsTrue(homePage.DeconectareButton.Displayed);

            Thread.Sleep(1000);
        }

    }
}

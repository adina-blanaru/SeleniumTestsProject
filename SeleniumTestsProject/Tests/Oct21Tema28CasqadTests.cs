using NUnit.Framework;
using SeleniumTestsProject.PageObjects;

namespace SeleniumTestsProject
{
    [TestFixture]
    //6.	Navigati catre pagina http://demosite.casqad.org/.  (teste diferite pentru fiecare punct)
    class Oct21Tema28CasqadTests : HooksOld
    {
        private readonly string SiteUrl = "http://demosite.casqad.org/";
        private readonly string AdminUser = "admin.test3@gmail.com";
        private readonly string AdminPassword = "password123";
        private readonly string AdinaUser = "ad_demo@test.com";
        private readonly string AdinaPassword = "demo123?";

        [Test]
        //a.	Logati-va in aplicatie.
        public void VerifyLoginWithValidCredentials()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser(AdminUser, AdminPassword);

            //Assert
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
        }

        [Test]
        //b.	Adaugati in cos un produs ca si utilizator.  -- fara sa fiu logat
        public void VerifyAddToCartAsGuest()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            ProductPage productPage = new ProductPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);

            //Act
            homePage.VeziDetaliiProdus();
            productPage.AdaugaInCos();

            //Assert
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Pentru a efectua aceasta actiune, va rugam sa va autentificati");            
        }


        [Test]
        //c.	Adaugati in cos un produs ca si admin.
        public void VerifyAddToCartAsAdmin()
        {
            CartPage cartPage = new CartPage(Driver);
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            ProductPage productPage = new ProductPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(AdminUser, AdminPassword);

            //Act
            homePage.VeziDetaliiProdus();
            productPage.AdaugaInCos();

            //Assert
            loginPage.VerifyElementIsDisplayed(cartPage.ComandaAcumButton);
        }

        [Test]
        //d.	Faceti inscrierea si logati-va cu noul cont.
        public void VerifySignUpAndLoginWithNewUser()
        {
            string Timestamp = System.DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss");
            string User = $"ad_demo_{Timestamp}@test.com";
            string Password = "demo123?";
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            SignUpPage signUpPage = new SignUpPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToSignUp();

            //Act 1
            signUpPage.CreateAccount("AD Demo User", User, "0744123456", "Strada mea, Brasov, Romania", Password);
            //Assert 1
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Your account was created, now you can login.");

            //Act 2
            loginPage.AuthenticateUser(User, Password);
            //Assert2
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);
        }

        [Test]
        //e.	Logati-va si deconectati-va din site.
        public void VerifyLoginAndLogout()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();

            //Act 1
            loginPage.AuthenticateUser(AdinaUser, AdinaPassword);
            //Assert 1
            loginPage.VerifyElementIsDisplayed(homePage.DeconectareButton);

            //Act 2
            homePage.DisconnectUser();
            //Assert 2
            loginPage.VerifyElementIsDisplayed(homePage.AutentificareButton);
        }

        [Test]
        //f.	Dati click pe fiecare meniu (orizontal).
        public void VerifyMenuNavigation()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);

            string[] menus = { "Laptopuri", "Telefoane", "Foto", "Carti", "Accesorii" };
            foreach (var menu in menus)
            {
                //Act
                homePage.GoToMenu(menu);
                //Assert
                loginPage.VerifyElementContainsText(homePage.CategoryLabel, menu);
            }
        }

        [Test]
        //g.	Ca si admin, dati click pe buton de administrare.
        public void VerifyAdministrationSectionAsAdmin()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(AdminUser, AdminPassword);

            //Act
            homePage.GoToMenu("Administrare");

            //Assert
            loginPage.VerifyElementIsDisplayed(homePage.GetMenuElement("Site"));
        }

        [Test]
        //h.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.
        public void VerifyUsersMenuAsAdmin()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            UtilizatoriPage utilizatoriPage = new UtilizatoriPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(AdminUser, AdminPassword);

            //Act
            homePage.GoToMenu("Administrare");
            homePage.GoToMenu("Utilizatori");

            //Assert
            loginPage.VerifyElementContainsText(utilizatoriPage.UsersTableHeader, "Email");
        }

        [Test]
        //i.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.
        public void VerifyEditUserAsAdmin()
        {
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            SignUpPage signUpPage = new SignUpPage(Driver);
            UtilizatoriPage utilizatoriPage = new UtilizatoriPage(Driver);

            //Arrange
            NavigateToUrl(SiteUrl);
            homePage.GoToAuthentication();
            loginPage.AuthenticateUser(AdminUser, AdminPassword);
            homePage.GoToMenu("Administrare");
            homePage.GoToMenu("Utilizatori");

            //Act
            //utilizatoriPage.EditUser();  //edit first user
            utilizatoriPage.ClickEditUser(AdinaUser);  //edit specific user
            signUpPage.FillInEmailField("edited@test.com");
            utilizatoriPage.ClickActualizeazaUtilizator();

            //Assert
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "The user has been successfully updated.");
            
            //Change email back to initial value
            signUpPage.FillInEmailField(AdinaUser);
            utilizatoriPage.ClickActualizeazaUtilizator();
        }
    }
}

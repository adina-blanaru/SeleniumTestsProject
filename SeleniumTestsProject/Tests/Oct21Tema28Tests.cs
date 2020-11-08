using NUnit.Framework;
using SeleniumTestsProject.PageObjectsOct21Tema28;
using SeleniumTestsProject.PageObjects;

namespace SeleniumTestsProject
{
    [TestFixture]
    class Oct21Tema28Tests : HooksOld
    {
        //nunit3-console.exe "C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\Unit Test Project\SeleniumTestsProject\SeleniumTestsProject\bin\Debug\SeleniumTestsProject.dll" --where "cat==myCat"

        [Test]
        //Navigati pe https://www.google.com/. Scrieti in campul de search “paris” si apasati pe butonul Google Search. 
        //Selectati “Images” din optiuni. Selectati prima imagine gasita.  Dati Back catre pagina cu imagini.
        public void GoogleSearchExercise()
        {      
            //Arrange
            NavigateToUrl("https://www.google.com/");
            GooglePage googlePage = new GooglePage();
            googlePage.AcceptTerms();

            //Act 1
            googlePage.GoogleSearch("paris");
            googlePage.ClickFirstResultFromImages();
            //Assert 1
            Assert.IsTrue(googlePage.IsImagePanelDisplayed());
            
            //Act 2
            googlePage.ReturnToImages();
            //Assert 2
            Assert.IsFalse(googlePage.IsImagePanelDisplayed());
        }

        [Test]
        //Navigati catre pagina https://demoqa.com/automation-practice-form. Completati TOATE campurile si apasati pe butonul de Submit.
        public void AutomationPracticeFormExercise()
        {
            //Arrange
            NavigateToUrl("https://demoqa.com/automation-practice-form");

            //Act
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(Driver);
            demoQaFormPage.FillInForm();
            demoQaFormPage.SubmitForm();

            //Assert
            Assert.AreEqual("Thanks for submitting the form", demoQaFormPage.ConfirmationDialogTitle.Text);
        }

        [Test]
        //Navigati catre pagina https://demoqa.com/text-box. Completati TOATE campurile si apasati pe butonul de Submit.
        public void DemoQaTextBoxExercise()
        {
            //Arrange
            NavigateToUrl("https://demoqa.com/text-box");

            //Act
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(Driver);
            demoQaTextBoxPage.FillInForm();
            demoQaTextBoxPage.SubmitForm();

            //Assert
            Assert.IsTrue(demoQaTextBoxPage.ConfirmationPanel.Displayed);
        }

        [Test]
        //Navigati catre pagina https://www.teatrulsicaalexandrescu.ro/?lang=en. 
        //Dati click pe Team(engleza) si selectati prima persoana din echipa. Dati click pe primul spectacol al persoanei respective.
        public void TeatrulSicaAlexandrescuExercise()
        {
            //Arrange
            NavigateToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");

            //Act
            TeatruPage teatruPage = new TeatruPage(Driver);
            teatruPage.TeamMenu.Click();
            Helper.ClickWithScroll(Driver, teatruPage.FirstActor);
            Helper.ClickWithScroll(Driver, teatruPage.FirstShow);
            /* OpenQA.Selenium.ElementClickInterceptedException: 'element click intercepted: 
            Element <a href="http://www.teatrulsicaalexandrescu.ro/prins-in-plasa/">...</a> is not clickable at point (227, 514). 
            Other element would receive the click: <span class="image-overlay overlay-type-image">...</span> */

            //Assert
            Assert.IsTrue(teatruPage.CumparaBiletButton.Displayed);
        }

        [Test]
        //Navigati catre pagina https://untold.com/. Dati click pe meniu si selectati pagina HOME.
        public void UntoldExercise()
        {
            //Arrange
            NavigateToUrl("https://untold.com/");

            //Act
            UntoldPage untoldPage = new UntoldPage(Driver);
            var a = untoldPage.UntoldRadio.Displayed;  //workaround to wait for UntoldRadio to be displayed
            untoldPage.MenuButton.Click();
            untoldPage.HomeMenuItem.Click();

            //Assert
            Assert.AreEqual("https://untold.com/", Driver.Url);
        }

    }
}

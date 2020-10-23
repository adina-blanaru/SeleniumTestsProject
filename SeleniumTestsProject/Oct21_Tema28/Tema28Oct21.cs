using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumTestsProject.PageObjects;
using System.Threading;

namespace SeleniumTestsProject
{
    [TestFixture]
    class Tema28Oct21 : Hooks
    {
        //nunit3-console.exe "C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\Unit Test Project\SeleniumTestsProject\SeleniumTestsProject\bin\Debug\SeleniumTestsProject.dll" --where "cat==myCat"

        [Test]
        //Navigati pe https://www.google.com/. Scrieti in campul de search “paris” si apasati pe butonul Google Search. 
        //Selectati “Images” din optiuni. Selectati prima imagine gasita.  Dati Back catre pagina cu imagini.
        public void GoogleSearchExercise()
        {
            //Arrange
            NavigateToUrl("https://www.google.com/");
            IWebElement consentIframe = Driver.FindElement(By.CssSelector("iframe"));
            Driver.SwitchTo().Frame(consentIframe);
            IWebElement agreeButton = Driver.FindElement(By.Id("introAgreeButton"));
            agreeButton.Click();

            //Act
            IWebElement SearchFieldTextBox = Driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
            SearchFieldTextBox.SendKeys("paris");
            Thread.Sleep(500);

            IWebElement GoogleSearchButton = Driver.FindElement(By.ClassName("gNO89b"));
            GoogleSearchButton.Click();

            IWebElement ImagesLink = Driver.FindElement(By.CssSelector(".hdtb-mitem.hdtb-imb a"));
            ImagesLink.Click();

            IWebElement FirstImage = Driver.FindElement(By.XPath("//div[1]/a[@jsname='sTFXNd']"));
            FirstImage.Click();

            IWebElement BackToImagesIcon = Driver.FindElement(By.ClassName("IA8gLe"));
            BackToImagesIcon.Click();

            //Assert
            Thread.Sleep(1000);
        }

        [Test]
        //Navigati catre pagina https://demoqa.com/automation-practice-form. Completati TOATE campurile si apasati pe butonul de Submit.
        public void AutomationPracticeFormExercise()
        {
            //Arrange
            NavigateToUrl("https://demoqa.com/automation-practice-form");

            //Act
            IWebElement FirstNameFieldTextBox = Driver.FindElement(By.Id("firstName"));
            FirstNameFieldTextBox.SendKeys("Test-first-name");

            IWebElement LastNameFieldTextBox = Driver.FindElement(By.Id("lastName"));
            LastNameFieldTextBox.SendKeys("Test-last-name");

            IWebElement EmailFieldTextBox = Driver.FindElement(By.Id("userEmail"));
            EmailFieldTextBox.SendKeys("testuser@test.com");

            IWebElement GenderFieldFemaleRadioButton = Driver.FindElement(By.XPath("//label[text()='Female']"));
            GenderFieldFemaleRadioButton.Click();

            IWebElement MobileFieldTextBox = Driver.FindElement(By.Id("userNumber"));
            MobileFieldTextBox.SendKeys("4123456789");

            IWebElement DateOfBirthFieldDatepicker = Driver.FindElement(By.Id("dateOfBirthInput"));
            DateOfBirthFieldDatepicker.Click();
            IWebElement monthDropdownSelect = Driver.FindElement(By.ClassName("react-datepicker__month-select"));
            var selectElement = new SelectElement(monthDropdownSelect);
            selectElement.SelectByText("March");

            IWebElement yearDropdownSelect = Driver.FindElement(By.ClassName("react-datepicker__year-select"));
            selectElement = new SelectElement(yearDropdownSelect);
            selectElement.SelectByValue("1970");

            IWebElement day = Driver.FindElement(By.CssSelector(".react-datepicker__day--012"));
            day.Click();

            IWebElement SubjectsFieldAutocomplete = Driver.FindElement(By.Id("subjectsInput"));
            for (int i = 0; i < 3; i++)
            {
                SubjectsFieldAutocomplete.SendKeys("t");
                SubjectsFieldAutocomplete.SendKeys(Keys.Enter);
            }

            //TODO upload photo

            IWebElement HobbiesSportsCheckbox = Driver.FindElement(By.XPath("//label[(text()='Sports')]"));
            HobbiesSportsCheckbox.Click();

            IWebElement AddressFieldTextBox = Driver.FindElement(By.Id("currentAddress"));
            AddressFieldTextBox.SendKeys("My Street 13, zipcode 55451");

            // added onclick="debugger" on the element to be able to see the menu options
            IWebElement StateDropdown = Driver.FindElement(By.Id("state"));
            scrollElementIntoView(StateDropdown);
            StateDropdown.Click();
            IWebElement FirstStateOption = Driver.FindElement(By.Id("react-select-3-option-0"));
            FirstStateOption.Click();

            // added onclick="debugger" on the element to be able to see the menu options
            IWebElement CityDropdown = Driver.FindElement(By.Id("city"));
            CityDropdown.Click();
            IWebElement FirstCityOption = Driver.FindElement(By.Id("react-select-4-option-0"));
            FirstCityOption.Click();

            IWebElement SubmitButton = Driver.FindElement(By.Id("submit"));
            SubmitButton.Click();

            //Assert
            IWebElement ConfirmationDialogTitle = Driver.FindElement(By.Id("example-modal-sizes-title-lg"));
            Assert.AreEqual("Thanks for submitting the form", ConfirmationDialogTitle.Text);
        }

        [Test]
        //Navigati catre pagina https://demoqa.com/text-box. Completati TOATE campurile si apasati pe butonul de Submit.
        public void DemoQaTextBoxExercise()
        {
            //Arrange
            NavigateToUrl("https://demoqa.com/text-box");

            //Act
            IWebElement FullNameFieldTextBox = Driver.FindElement(By.Id("userName"));
            FullNameFieldTextBox.SendKeys("Test User Full Name");

            IWebElement EmailFieldTextBox = Driver.FindElement(By.Id("userEmail"));
            EmailFieldTextBox.SendKeys("testuser@test.com");

            IWebElement CurrentAddressFieldTextBox = Driver.FindElement(By.Id("currentAddress"));
            CurrentAddressFieldTextBox.SendKeys("My current street 11, Brasov, Romania");

            IWebElement PermanentAddressFieldTextBox = Driver.FindElement(By.Id("permanentAddress"));
            PermanentAddressFieldTextBox.SendKeys("My permanent street 101, Brasov, Romania");

            IWebElement SubmitButton = Driver.FindElement(By.Id("submit"));
            SubmitButton.Click();

            //Assert
            IWebElement ConfirmationPanel = Driver.FindElement(By.Id("output"));
            Assert.IsTrue(ConfirmationPanel.Displayed);
        }

        [Test]
        //Navigati catre pagina https://www.teatrulsicaalexandrescu.ro/?lang=en. 
        //Dati click pe Team(engleza) si selectati prima persoana din echipa. Dati click pe primul spectacol al persoanei respective.
        public void TeatrulSicaAlexandrescuExercise()
        {
            //Arrange
            NavigateToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");

            //Act
            IWebElement TeamMenu = Driver.FindElement(By.XPath("//span[(text()='Team')]"));
            TeamMenu.Click();

            IWebElement FirstActor = Driver.FindElement(By.Id("av-masonry-1-item-2697"));
            //IWebElement FirstActor = Driver.FindElement(By.XPath("//a[starts-with(@id,'av-masonry-1-item-')][1]"));
            scrollElementIntoView(FirstActor);
            FirstActor.Click();

            IWebElement FirstShow = Driver.FindElement(By.XPath("//div/p/a/strong"));
            scrollElementIntoView(FirstShow);
            FirstShow.Click();   //TODO

            //Assert
            IWebElement CumparaBiletButton = Driver.FindElement(By.XPath("//span[text()='CUMPARA BILET']"));
            Assert.IsTrue(CumparaBiletButton.Displayed);
        }

        [Test]
        //Navigati catre pagina https://untold.com/. Dati click pe meniu si selectati pagina HOME.
        public void UntoldExercise()
        {
            //Arrange
            NavigateToUrl("https://untold.com/");

            //Act
            IWebElement MenuButton = Driver.FindElement(By.CssSelector(".bm-burger-button button"));
            MenuButton.Click();

            IWebElement HomeMenuItem = Driver.FindElement(By.XPath("//span[text()='HOME']"));
            HomeMenuItem.Click();

            //Assert
            Assert.AreEqual("https://untold.com/", Driver.Url);
        }

    }
}

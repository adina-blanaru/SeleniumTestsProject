using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class DemoQaFormPage
    {
        private IWebDriver _driver;
        public DemoQaFormPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement FirstNameFieldTextBox => _driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameFieldTextBox => _driver.FindElement(By.Id("lastName"));
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.Id("userEmail"));
        private IWebElement MobileFieldTextBox => _driver.FindElement(By.Id("userNumber"));

        private IWebElement DateOfBirthFieldDatepicker => _driver.FindElement(By.Id("dateOfBirthInput"));
        private IWebElement MonthDropdownSelect => _driver.FindElement(By.ClassName("react-datepicker__month-select"));
        private IWebElement YearDropdownSelect => _driver.FindElement(By.ClassName("react-datepicker__year-select"));

        private IWebElement SubjectsFieldAutocomplete => _driver.FindElement(By.Id("subjectsInput"));
        private IWebElement ChooseFileButton => _driver.FindElement(By.Id("uploadPicture"));
        private IWebElement CurrentAddressFieldTextBox => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement StateDropdown => _driver.FindElement(By.CssSelector("#state input"));    
        private IWebElement CityDropdown => _driver.FindElement(By.CssSelector("#city input"));

        private IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement ConfirmationDialogTitle => _driver.FindElement(By.Id("example-modal-sizes-title-lg"));
    }
}

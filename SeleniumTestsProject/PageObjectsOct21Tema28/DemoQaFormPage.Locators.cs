using OpenQA.Selenium;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class DemoQaFormPage : BaseDriver
    {
        private IWebDriver _driver;
        public DemoQaFormPage(IWebDriver driver)
        {
            _driver = Driver;
        }

        private IWebElement FirstNameFieldTextBox => _driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameFieldTextBox => _driver.FindElement(By.Id("lastName"));
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.Id("userEmail"));
        private IWebElement GenderFieldFemaleRadioButton => _driver.FindElement(By.XPath("//label[text()='Female']"));
        private IWebElement MobileFieldTextBox => _driver.FindElement(By.Id("userNumber"));

        private IWebElement DateOfBirthFieldDatepicker => _driver.FindElement(By.Id("dateOfBirthInput"));
        private IWebElement MonthDropdownSelect => _driver.FindElement(By.ClassName("react-datepicker__month-select"));
        private IWebElement YearDropdownSelect => _driver.FindElement(By.ClassName("react-datepicker__year-select"));

        private IWebElement SubjectsFieldAutocomplete => _driver.FindElement(By.Id("subjectsInput"));

        private IWebElement HobbiesSportsCheckbox => _driver.FindElement(By.XPath("//label[(text()='Sports')]"));
        private IWebElement ChooseFileButton => _driver.FindElement(By.Id("uploadPicture"));
        private IWebElement AddressFieldTextBox => _driver.FindElement(By.Id("currentAddress"));

        private IWebElement StateDropdown => _driver.FindElement(By.Id("state"));
        // added onclick="debugger" on the element to be able to see the menu options
        private IWebElement FirstStateOption => _driver.FindElement(By.Id("react-select-3-option-0"));
        
        private IWebElement CityDropdown => _driver.FindElement(By.Id("city"));
        private IWebElement FirstCityOption => _driver.FindElement(By.Id("react-select-4-option-0"));
        
        private IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement ConfirmationDialogTitle => _driver.FindElement(By.Id("example-modal-sizes-title-lg"));
    }
}

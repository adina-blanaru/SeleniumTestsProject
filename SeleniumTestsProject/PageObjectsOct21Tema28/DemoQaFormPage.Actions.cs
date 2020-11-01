using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestsProject.PageObjects;
using System.IO;
using System.Reflection;
using System.Threading;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class DemoQaFormPage
    {
        public void FillInForm()
        {
            FirstNameFieldTextBox.SendKeys("Test-first-name");
            LastNameFieldTextBox.SendKeys("Test-last-name");
            EmailFieldTextBox.SendKeys("testuser@test.com");
            GenderFieldFemaleRadioButton.Click();
            MobileFieldTextBox.SendKeys("4123456789");
            SelectDateOfBirth("12", "March", "1970");
            for (int i = 0; i < 3; i++)
            {
                SelectSubjectAutocompleteValue("t");
            }
            HobbiesSportsCheckbox.Click();

            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChooseFileButton.SendKeys($"{path}\\Resources\\test-img.JPG");
            
            AddressFieldTextBox.SendKeys("My Street 13, zipcode 55451");

            Helper.ScrollElementIntoView(_driver, StateDropdown);
            StateDropdown.Click();
            FirstStateOption.Click();

            CityDropdown.Click();
            FirstCityOption.Click();
        }

        public void SubmitForm()
        {
            SubmitButton.Click();
            Thread.Sleep(500);
        }

        private void SelectDateOfBirth(string day, string month, string year)
        {
            SelectElement selectElement;

            DateOfBirthFieldDatepicker.Click();
            selectElement = new SelectElement(MonthDropdownSelect);
            selectElement.SelectByText(month);

            selectElement = new SelectElement(YearDropdownSelect);
            selectElement.SelectByValue(year);

            _driver.FindElement(By.CssSelector($".react-datepicker__day--0{day}")).Click();
        }

        private void SelectSubjectAutocompleteValue(string text)
        {
            SubjectsFieldAutocomplete.SendKeys(text);
            Thread.Sleep(10);
            SubjectsFieldAutocomplete.SendKeys(Keys.Tab);
        }  

    }
}

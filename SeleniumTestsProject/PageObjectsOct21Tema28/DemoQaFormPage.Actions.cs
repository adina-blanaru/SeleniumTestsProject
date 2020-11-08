using Gherkin;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestsProject.Dto;
using SeleniumTestsProject.PageObjects;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class DemoQaFormPage
    {
        public void FillInForm(DemoQaUserDetailsDto user)
        {
            var FirstNameValue = user.GetType().GetRuntimeProperty("FirstName").GetValue(user);
            if (FirstNameValue != null)
            {
                FirstNameFieldTextBox.SendKeys(FirstNameValue.ToString());
            }

            var LastNameValue = user.GetType().GetRuntimeProperty("LastName").GetValue(user);
            if (LastNameValue != null)
            {
                LastNameFieldTextBox.SendKeys(LastNameValue.ToString());
            }

            var EmailValue = user.GetType().GetRuntimeProperty("Email").GetValue(user);
            if (EmailValue != null)
            {
                EmailFieldTextBox.SendKeys(EmailValue.ToString());
            }

            var GenderValue = user.GetType().GetRuntimeProperty("Gender").GetValue(user);
            if (GenderValue != null)
            {
                _driver.FindElement(By.XPath($"//label[text()='{GenderValue}']")).Click();
            }

            var MobilePhoneValue = user.GetType().GetRuntimeProperty("MobilePhone").GetValue(user);
            if (MobilePhoneValue != null)
            {
                MobileFieldTextBox.SendKeys(MobilePhoneValue.ToString());
            }

            var DateOfBirthValue = user.GetType().GetRuntimeProperty("DateOfBirth").GetValue(user);
            if (DateOfBirthValue != null)
            {
                var dob = DateOfBirthValue.ToString().Split('/').ToList();
                SelectDateOfBirth(dob[0], dob[1], dob[2]);
            }

            var SubjectsValue = user.GetType().GetRuntimeProperty("Subjects").GetValue(user);
            if (SubjectsValue != null)
            {
                var subjects = SubjectsValue.ToString().Split(',').ToList();
                foreach (var subject in subjects)
                {
                    SelectSubject(subject);
                }
            }

            var HobbiesValue = user.GetType().GetRuntimeProperty("Hobbies").GetValue(user);
            if (HobbiesValue != null)
            {
                var hobbies = HobbiesValue.ToString().Split(',').ToList();
                foreach (var hobby in hobbies)
                {
                    _driver.FindElement(By.XPath($"//label[text()='{hobby.Trim()}']")).Click();
                }
            }

            var PictureNameValue = user.GetType().GetRuntimeProperty("PictureName").GetValue(user);
            if (PictureNameValue != null)
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                ChooseFileButton.SendKeys($"{path}\\Resources\\{PictureNameValue}");
            }

            var CurrentAddressValue = user.GetType().GetRuntimeProperty("CurrentAddress").GetValue(user);
            if (CurrentAddressValue != null)
            {
                CurrentAddressFieldTextBox.SendKeys(CurrentAddressValue.ToString());
            }

            var StateValue = user.GetType().GetRuntimeProperty("State").GetValue(user);
            if (StateValue != null)
            {
                Helper.ScrollElementIntoView(_driver, StateDropdown);
                SelectFromDropdown(StateDropdown, StateValue.ToString());
            }

            var CityValue = user.GetType().GetRuntimeProperty("City").GetValue(user);
            if (CityValue != null)
            {
                SelectFromDropdown(CityDropdown, CityValue.ToString());
            }
        }

        public void SubmitForm()
        {
            SubmitButton.Click();
            Thread.Sleep(500);
        }

        private void SelectDateOfBirth(string month, string day, string year)
        {
            SelectElement selectElement;
            DateOfBirthFieldDatepicker.Click();
            selectElement = new SelectElement(MonthDropdownSelect);
            selectElement.SelectByValue((int.Parse(month) - 1).ToString());

            selectElement = new SelectElement(YearDropdownSelect);
            selectElement.SelectByValue(year);

            _driver.FindElement(By.CssSelector($".react-datepicker__day--0{day}")).Click();
        }

        private void SelectSubject(string text)
        {
            SubjectsFieldAutocomplete.SendKeys(text);
            Thread.Sleep(10);
            SubjectsFieldAutocomplete.SendKeys(Keys.Tab);
        }

        private void SelectFromDropdown(IWebElement dropdown, string text)
        {            
            dropdown.SendKeys(text);
            dropdown.SendKeys(Keys.Tab);
        }

    }
}

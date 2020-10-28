
namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class DemoQaTextBoxPage
    {
        public void FillInForm()
        {
            FullNameFieldTextBox.SendKeys("Test User Full Name");
            EmailFieldTextBox.SendKeys("testuser@test.com");
            CurrentAddressFieldTextBox.SendKeys("My current street 11, Brasov, Romania");
            PermanentAddressFieldTextBox.SendKeys("My permanent street 101, Brasov, Romania");
            SubmitButton.Click();
        }

        public void SubmitForm()
        {
            SubmitButton.Click();
        }
    }
}

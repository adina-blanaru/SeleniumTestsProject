
using SeleniumTestsProject.Dto;
using System.Reflection;
using System.Threading;

namespace SeleniumTestsProject.PageObjects.Misc
{
    partial class DemoQaTextBoxPage
    {
        public void FillInForm(DemoQaUserAddressInfoDto user)
        {
            var FullNameValue = user.GetType().GetRuntimeProperty("FullName").GetValue(user);
            if (FullNameValue != null)
            {
                FullNameFieldTextBox.SendKeys(FullNameValue.ToString());
            }

            var EmailValue = user.GetType().GetRuntimeProperty("Email").GetValue(user);
            if (EmailValue != null)
            {
                EmailFieldTextBox.SendKeys(EmailValue.ToString());
            }

            var CurrentAddressValue = user.GetType().GetRuntimeProperty("CurrentAddress").GetValue(user);
            if (CurrentAddressValue != null)
            {
                CurrentAddressFieldTextBox.SendKeys(CurrentAddressValue.ToString());
            }

            var PermanentAddressValue = user.GetType().GetRuntimeProperty("PermanentAddress").GetValue(user);
            if (PermanentAddressValue != null)
            {
                PermanentAddressFieldTextBox.SendKeys(PermanentAddressValue.ToString());
            }
        }

        public void SubmitForm()
        {
            SubmitButton.Click();
        }
    }
}

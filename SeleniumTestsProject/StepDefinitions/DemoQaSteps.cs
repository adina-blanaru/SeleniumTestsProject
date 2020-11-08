using NUnit.Framework;
using SeleniumTestsProject.Dto;
using SeleniumTestsProject.PageObjectsOct21Tema28;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class DemoQaSteps : Hooks
    {
        [When(@"I fill in the registration form")]
        public void WhenIFillInTheRegistrationForm(Table table)
        {
            var myUser = table.CreateInstance<DemoQaUserDetailsDto>();
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(Driver);
            demoQaFormPage.FillInForm(myUser);
            demoQaFormPage.SubmitForm();
        }

        [Then(@"I should see the confirmation that the form was submitted")]
        public void ThenIShouldSeeTheConfirmationThatTheFormWasSubmitted()
        {
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(Driver);
            Assert.AreEqual("Thanks for submitting the form", demoQaFormPage.ConfirmationDialogTitle.Text);
        }

        [When(@"I fill in the text box form")]
        public void WhenIFillInTheTextBoxForm(Table table)
        {
            var myUser = table.CreateInstance<DemoQaUserAddressInfoDto>();
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(Driver);
            demoQaTextBoxPage.FillInForm(myUser);
            demoQaTextBoxPage.SubmitForm();
        }

        [Then(@"I should see the confirmation panel")]
        public void ThenIShouldSeeTheConfirmationPanel()
        {
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(Driver);
            Assert.IsTrue(demoQaTextBoxPage.ConfirmationPanel.Displayed);
        }


    }
}

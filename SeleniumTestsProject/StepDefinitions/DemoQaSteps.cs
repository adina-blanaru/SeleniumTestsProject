using NUnit.Framework;
using SeleniumTestsProject.PageObjectsOct21Tema28;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class DemoQaSteps : BaseDriver
    {
        [When(@"I fill in the registration form")]
        public void WhenIFillInTheRegistrationForm()
        {
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(Driver);
            demoQaFormPage.FillInForm();  //TODO use table for the data
            demoQaFormPage.SubmitForm();
        }

        [Then(@"I should see the confirmation that the form was submitted")]
        public void ThenIShouldSeeTheConfirmationThatTheFormWasSubmitted()
        {
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(Driver);
            Assert.AreEqual("Thanks for submitting the form", demoQaFormPage.ConfirmationDialogTitle.Text);
        }

        [When(@"I fill in the text box form")]
        public void WhenIFillInTheTextBoxForm()
        {
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(Driver);
            demoQaTextBoxPage.FillInForm();  //TODO use table for the data
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

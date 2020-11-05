using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumTestsProject.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public StepDefinition1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {

        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            
        }
    }
}

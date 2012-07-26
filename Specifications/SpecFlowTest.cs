using System;
using TechTalk.SpecFlow;

namespace Specifications
{
    [Binding]
    public class SpecFlowTest
    {
        [Given(@"I have written a test")]
        public void GivenIHaveWrittenATest()
        {
           
        }

        [When(@"I run the test")]
        public void WhenIRunTheTest()
        {
            
        }

        [Then(@"the test passes")]
        public void ThenTheTestPasses()
        {
            
        }

        [Then(@"the test fails")]
        public void ThenTheTestFails()
        {
            throw new Exception();
        }

        [Then(@"not in the last step")]
        public void ThenNotInTheLastStep()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the test is pending")]
        public void ThenTheTestIsPending()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

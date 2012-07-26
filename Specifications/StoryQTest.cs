using System;
using NUnit.Framework;
using StoryQ;

namespace Specifications
{
    [TestFixture]
    public class StoryQTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void PassingTest()
        {
            new Story("Standard Specification")
                .InOrderTo("evaluate storyq against specflow")
                .AsA("developer")
                .IWant("have a look at the report generation")
                .And("inspect the ways to generate specs")
                    .WithScenario("Passing Test")
                        .Given(IHaveWrittenATest)
                        .When(IRunTheTest)
                        .Then(TheTestPasses)
                        .Execute();
        }

        [Test]
        public void FailingTest()
        {
            new Story("Standard Specification")
                .InOrderTo("evaluate storyq against specflow")
                .AsA("developer")
                .IWant("have a look at the report generation")
                .And("inspect the ways to generate specs")
                    .WithScenario("Failing Test")
                        .Given(IHaveWrittenATest)
                        .When(IRunTheTest)
                        .Then(TheTestFails)
                        .Execute();
        }

        [Test]
        public void FailingTestWithMultipleSteps()
        {
            new Story("Standard Specification")
                .InOrderTo("evaluate storyq against specflow")
                .AsA("developer")
                .IWant("have a look at the report generation")
                .And("inspect the ways to generate specs")
                    .WithScenario("Failing Test With Multiple Steps")
                        .Given(IHaveWrittenATest)
                        .When(IRunTheTest)
                        .Then(TheTestFails)
                        .And(NotInTheLastStep)
                        .Execute();
        }

        [Test]
        public void PendingTest()
        {
            new Story("Standard Specification")
                .InOrderTo("evaluate storyq against specflow")
                .AsA("developer")
                .IWant("have a look at the report generation")
                .And("inspect the ways to generate specs")
                    .WithScenario("Pending Test")
                        .Given(IHaveWrittenATest)
                        .When(IRunTheTest)
                        .Then(TheTestIsPending)
                        .Execute();
        }

        [Test]
        public void PendingTestWithMultipleSteps()
        {
            new Story("Standard Specification")
                .InOrderTo("evaluate storyq against specflow")
                .AsA("developer")
                .IWant("have a look at the report generation")
                .And("inspect the ways to generate specs")
                    .WithScenario("Pending Test With Multiple Steps")
                        .Given(IHaveWrittenATest)
                        .When(IRunTheTest)
                        .Then(TheTestIsPending)
                        .And(NotInTheLastStep)
                        .Execute();
        }
        
        private void TheTestPasses()
        {
        }

        private void TheTestFails()
        {
            throw new Exception();
        }

        private void IHaveWrittenATest()
        {
        }

        private void IRunTheTest()
        {
        }

        private void TheTestIsPending()
        {
            throw new NotImplementedException();
        }

        private void NotInTheLastStep()
        {
        }
    }
}

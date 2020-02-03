//namespace SimpleApi.Specs.Impl1

using System;
using TechTalk.SpecFlow;

namespace SimpleApi.Specs.Impl2
{
    [Binding]
    public class StepDefinitions
    {
        [When(@"I create a TodoItem")]
        public void WhenICreateATodoItem()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Impl2: I create a TodoItem");
        }

        [Then(@"I get an Id")]
        public void ThenIGetAnId()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Impl2: I get an Id");
            throw new Exception("hey!"); 
        }
    }
}
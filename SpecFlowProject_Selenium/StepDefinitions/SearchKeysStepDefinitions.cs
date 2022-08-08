using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject_Selenium.StepDefinitions
{
    [Binding]
    public class SearchKeysStepDefinitions
    {
       
        [Given(@"I have (.*) different keys")]
        public void GivenIHaveDifferentKeys(int numberOfKeys)
        {
            object car;
            

        }

        [When(@"I try one by one of the keys with the car")]
        public void WhenITryOneByOneOfTheKeysWithTheCar()
        {
            
        }

        [Then(@"the correct key will start the car")]
        public void ThenTheCorrectKeyWillStartTheCar()
        {
            
        }
    }
}

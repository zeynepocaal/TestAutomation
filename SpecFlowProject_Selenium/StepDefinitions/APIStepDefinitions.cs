using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject_Selenium.StepDefinitions
{
    [Binding]
    public class APIStepDefinitions
    {
        IWebDriver driver;

        [Given(@"Go to gorest website")]
        public void GivenGoToGorestWebsite()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://gorest.co.in");
        }
       
        [Given(@"send request get user details")]
        public void GivenSendRequestGetUserDetails()
        {
            using (var client = new HttpClient())
            {
                //Endpoint istemciler (clients) ve host'lar arasýndaki iletiþimi þaðlamak için kullanýlan bir arayüzdür.
                var endpoint = new Uri("https://gorest.co.in/public/v2/users");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                
            }
        }

        [When(@"gender and status situation true")]
        public void WhenGenderAndStatusSituationTrue()
        {
            
        }

        [Then(@"execute the test")]
        public void ThenExecuteTheTest()
        {
            
        }
    }
}

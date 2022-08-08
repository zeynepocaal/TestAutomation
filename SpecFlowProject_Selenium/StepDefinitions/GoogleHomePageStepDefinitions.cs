using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject_Selenium.StepDefinitions
{
    [Binding]
    public class GoogleHomePageStepDefinitions
    {
        IWebDriver driver;

        [Given(@"Go to Google")]
        public void GivenGoToGoogle()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [When(@"I enter keyword in search box click button")]
        public void WhenIEnterKeywordİnSearchBoxClickButton()
        {
            driver.FindElement(By.Name("q")).SendKeys("Tesla");
            Thread.Sleep(2000);
            driver.FindElement(By.Name("btnI")).Click();
        }

        [Then(@"I check the title then look for equality")]
        public void ThenICheckTheTitleThenLookForEquality()
        {
            //string value = driver.FindElement(By.Name("q")).GetAttribute("title");
            Assert.AreNotEqual("Clean Energy", driver.Title);
            driver.Quit();
        }
    }
}

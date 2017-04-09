using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Task2Project
{
    [Binding]
    public class BrowserCreationSteps
    {
        private IWebDriver _driver;
        WebDriverWait wait;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [Given(@"I navigate to (.*) url")]
        public void GivenINavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            ScenarioContext.Current.Add("driver", _driver);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

       

      
    }
}

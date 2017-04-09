using OpenQA.Selenium;
using Task2Project.ANZ.PageObjects;
using TechTalk.SpecFlow;

namespace Task2Project.ANZ.Steps
{
    [Binding]
    public class ANZPersonalTabSteps
    {
      
        private IWebDriver _driver;
        private ANZHomePage _anzHomePage;
        private ANZPersonalTab _anzPersonalTab;

        public ANZPersonalTabSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _anzHomePage = new ANZHomePage(_driver);
            _anzPersonalTab = new ANZPersonalTab(_driver);

        }

        [Given(@"I click (.*) button")]
        public void GivenISelectButton(string textToClick)
        {
            _anzPersonalTab.ClickByText(textToClick);
        }

        [Given(@"I click (.*) tab")]
        public void GivenIClickTab(string tab)
        {
            _anzPersonalTab.ClickPersonal(tab);
        }

        //[Given(@"I click  (.*) button")]
        //public void GivenIClickButton(string p0)
        //{
        //    _anzPersonalTab.StartApplication();
        //}

        [Then(@"I should see (.*) name of the page")]
        public void ThenIShouldSeeNameOfThePage(string startApplicationPageName)
        {
            _anzPersonalTab.FindStartApplicationPageNameText(startApplicationPageName);
        }

    }
}

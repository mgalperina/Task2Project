using OpenQA.Selenium;
using Task2Project.ANZ.PageObjects;
using TechTalk.SpecFlow;

namespace Task2Project
{
    [Binding]
    public class ANZHomeLoanSteps
    {
        private IWebDriver _driver;
        private ANZHomePage _anzHomePage;
        private HomeLoanCalculatorPage _homeLoanCalculatorPage;

        public ANZHomeLoanSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _anzHomePage = new ANZHomePage(_driver);
            _homeLoanCalculatorPage = new HomeLoanCalculatorPage(_driver);
        }
         
        [When(@"I choose (.*) application")]
        public void WhenIChooseApplication(string applicationType)
        {
            _homeLoanCalculatorPage.ChangeToJoint(applicationType);
        }
        
        [When(@"I add one dependant child")]
        public void WhenIAddOneDependantChild()
        {
            _homeLoanCalculatorPage.AddChild();
        }

        [When(@"I add one vehicle")]
        public void WhenIAddOneVehicle()
        {
            _homeLoanCalculatorPage.AddVehicle();
        }



    }
}

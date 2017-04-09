using NUnit.Framework;
using OpenQA.Selenium;
using Task2Project.ANZ.PageObjects;
using TechTalk.SpecFlow;

namespace Task2Project.ANZ.Steps
{
    [Binding]
    public class HomeLoanCommonSteps
    {
  
        private IWebDriver _driver;
        private ANZHomePage _anzHomePage;
        private HomeLoanCalculatorPage _homeLoanCalculatorPage;

        public HomeLoanCommonSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _anzHomePage = new ANZHomePage(_driver);
            _homeLoanCalculatorPage = new HomeLoanCalculatorPage(_driver);
        }

        [When(@"I select (.*) tab")]
        public void WhenISelectTab(string tab)
        {
             _anzHomePage.SelectHomeLoanPage(tab);
        }

        [When(@"I type (.*) into an income field")]
        public void WhenITypeIntoAnIncomeField(double income)
        {
            _homeLoanCalculatorPage.TypeIncome(income);
        }

        [When(@"I click (.*) to calculate")]
        public void WhenIClickToCalculate(string p0)
        {
            _homeLoanCalculatorPage.ClickCalculate();
        }


        [Then(@"I should see (.*) for each income rate")]
        public void ThenIShouldSeeForEachIncomeRate(string expectedMonthlyRepayment)
        {
            Assert.AreEqual(expectedMonthlyRepayment, _homeLoanCalculatorPage.GetMonthlyRepayment());
        }

    }
}

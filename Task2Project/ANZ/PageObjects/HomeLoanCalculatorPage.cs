using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace Task2Project.ANZ.PageObjects
{
    public class HomeLoanCalculatorPage
    {
        private readonly IWebDriver _driver;
        WebDriverWait wait;

        public HomeLoanCalculatorPage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "Income_AnnualHousehold")]
        public IWebElement _incomeField;

        [FindsBy(How = How.Id, Using = "baseSubmit")]
        public IWebElement _calculateButton;

        [FindsBy(How = How.XPath, Using = "//input[@value='+']")]
        public IWebElement _addChild;
        
        [FindsBy(How = How.CssSelector, Using = ".xxxlarge")]
        public IWebElement _monthlyRepaymentField;

        [FindsBy(How = How.Id, Using = "simpleJointType")]
        public IWebElement _jointApplicationRadioButton;

        [FindsBy(How = How.XPath, Using = ".//div[4]/div[2]/input")]
        public IWebElement _addVehicleButton;

        public string GetMonthlyRepayment()
        {
            wait.Until(_driver => _monthlyRepaymentField.Text.Length > 0);
            var monthlyRepayment = _monthlyRepaymentField.Text;
            return monthlyRepayment;
        }

        public void AddChild()
        {
            _addChild.Click();
        }

        public void ChangeToJoint(string applicationType)
        {
            
            _jointApplicationRadioButton.Click();
        }

        public void TypeIncome(double income)
        {
            _incomeField.Click();
            _incomeField.SendKeys(income.ToString());
            
        }

        public void ClickCalculate()
        {
            _calculateButton.Click();
        }

        public void AddVehicle()
        {
            _addVehicleButton.Click();
        }


    }
}

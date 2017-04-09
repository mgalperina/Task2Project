using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;


namespace Task2Project.ANZ.PageObjects
{
    public class ANZHomePage
    {
        private readonly IWebDriver _driver;
        WebDriverWait wait;

        public ANZHomePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
         }

        [FindsBy(How = How.XPath, Using = ".//div[@id='ff_slot1']/div/div/a/span[2]")]
        public IWebElement _dropdownCalculators;

        [FindsBy(How = How.XPath, Using = ".//div[@class='subNav']/ul/li[4]")]
        public IWebElement _homeLoanButton;

        public void SelectHomeLoanPage(string tab)
        {
            wait.Until(_driver => _dropdownCalculators.Displayed);
            _dropdownCalculators.Click();
            _homeLoanButton.Click();
         }

    

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;


namespace Task2Project.ANZ.PageObjects
{
    public class ANZPersonalTab
    {
        private readonly IWebDriver _driver;
        WebDriverWait wait;

        public ANZPersonalTab(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "Next")]
        public IWebElement _startNowButton;

        [FindsBy(How = How.ClassName, Using = "primaryHeading")]
        public IWebElement _startApplicationPageName;

        [FindsBy(How = How.Id, Using = "tabs-personal")]
        public IWebElement _personalTab;


        public void ClickByText(string textToClick)
        {
            
            _driver.FindElement(By.XPath($"//*[text()[contains(.,'{textToClick}')]]")).Click();

        }

        //public void StartApplication()
        //{
        //    _startNowButton.Click();
        //}

        public void FindStartApplicationPageNameText(string startApplicationPageName)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            _driver.FindElement(By.ClassName("primaryHeading"));

        }

        public string GetStartApplicationPageName()
        {
            return _startApplicationPageName.Text;
        }

        public void ClickPersonal(string tab)
        {
            wait.Until(_driver => _personalTab.Displayed);
            _personalTab.Click();

            //Actions action = new Actions(_driver);
            //action.MoveToElement(_personalTab).Perform();
        }
    }
}

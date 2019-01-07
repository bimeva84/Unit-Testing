using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QAAutomation.Framework.PageObjects
{
    public class RegistrationPage
    {
        private IWebDriver driver;
        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "Email")]
        private IWebElement Email;

        public void GoToPage(String queryParams = "")
        {
            driver.Navigate().GoToUrl("https://aws-test.taxact.com/" + queryParams);
        }
    }
}

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {

        private IWebDriver _driver;

        [Given(@"User is on the Orange HRM Login Page")]
        public void GivenUserIsOnTheOrangeHRMLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in input field\.")]
        public void WhenUserEntersTheAndInInputField_(string user, string password)
        {
            IWebElement username = _driver.FindElement(By.Name("username"));
            username.SendKeys(user);
            IWebElement passw = _driver.FindElement(By.Name("password"));
            passw.SendKeys(password);
        }

        [When(@"User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement loginBtn = _driver.FindElement(By.XPath("//button[contains(@type,'submit')]"));
            loginBtn.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is navigated to Orange hrm home page")]
        public void ThenUserIsNavigatedToOrangeHrmHomePage()
        {
            IWebElement dashboardSection = _driver.FindElement(By.XPath("//h6[contains(normalize-space(),'Dashboard')]"));

            Assert.That(dashboardSection.Text, Is.EqualTo("Dashboard"));
            Thread.Sleep(2000);
            _driver.Close();
        }
    }
}

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMInvalidParmTestCasesStepDefinitions
    {
        private IWebDriver _driver;


        [Given(@"User is on the Orange HRM Login Page\.")]
        public void GivenUserIsOnTheOrangeHRMLoginPage_()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in input\.")]
        public void WhenUserEntersTheAndInInput_(string user, string pass)
        {
            IWebElement username = _driver.FindElement(By.Name("username"));
            username.SendKeys(user);
            IWebElement passw = _driver.FindElement(By.Name("password"));
            passw.SendKeys(pass);
        }

        [When(@"User clicks on Login button\.")]
        public void WhenUserClicksOnLoginButton_()
        {
            IWebElement loginBtn = _driver.FindElement(By.XPath("//button[contains(@type,'submit')]"));
            loginBtn.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is displayed with Invalid Credentials\.")]
        public void ThenUserIsDisplayedWithInvalidCredentials_()
        {
            IWebElement invalidSection = _driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid credentials')]"));

            Assert.That(invalidSection.Text, Is.EqualTo("Invalid credentials"));
            Thread.Sleep(2000);
            _driver.Close();
        }
    }
}

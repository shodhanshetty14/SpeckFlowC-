using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaBankInvalidCredentialsLoginTesCasesStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"User is on the Para bank Login Page\.")]
        public void GivenUserIsOnTheParaBankLoginPage_()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the input\.")]
        public void WhenUserEntersTheAndInTheInput_(string user, string pass)
        {
            IWebElement username = _driver.FindElement(By.Name("username"));
            username.SendKeys(user);
            IWebElement passw = _driver.FindElement(By.Name("password"));
            passw.SendKeys(pass);
        }

        [When(@"User clicks on the Login button\.")]
        public void WhenUserClicksOnTheLoginButton_()
        {
            IWebElement loginBtn = _driver.FindElement(By.XPath("//input[contains(@value,'Log In')]"));
            loginBtn.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is displayed with Invalid Credentials Message\.")]
        public void ThenUserIsDisplayedWithInvalidCredentialsMessage_()
        {
            IWebElement errorMessage = _driver.FindElement(By.ClassName("error"));
            Assert.That(errorMessage.Text, Is.EqualTo("The username and password could not be verified."));
            _driver.Close();
        }
    }
}

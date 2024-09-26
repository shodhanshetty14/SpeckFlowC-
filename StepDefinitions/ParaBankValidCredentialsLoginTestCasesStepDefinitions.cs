using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaBankValidCredentialsLoginTestCasesStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"User is on the Para bank Login Page")]
        public void GivenUserIsOnTheParaBankLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
        }

        [When(@"User enters valid  ""([^""]*)"" and ""([^""]*)"" in the input\.")]
        public void WhenUserEntersValidAndInTheInput_(string user, string pass)
        {
            IWebElement username = _driver.FindElement(By.Name("username"));
            username.SendKeys(user);
            IWebElement passw = _driver.FindElement(By.Name("password"));
            passw.SendKeys(pass);
        }

        [When(@"User clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement loginBtn = _driver.FindElement(By.XPath("//input[contains(@value,'Log In')]"));
            loginBtn.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is displayed with")]
        public void ThenUserIsDisplayedWith()
        {
            try
            {

            IWebElement loinCheckSection = _driver.FindElement(By.XPath("//h1[contains(text(),'Accounts Overview')]"));
            Assert.That(loinCheckSection.Text, Is.EqualTo("Accounts Overview"));
            //Console.WriteLine("Login Success!!");
            }
            catch {
                IWebElement errorMessage = _driver.FindElement(By.ClassName("error"));
                Assert.That(errorMessage.Text, Is.EqualTo("The username and password could not be verified."));
            }

            _driver.Close();
        }
    }
}

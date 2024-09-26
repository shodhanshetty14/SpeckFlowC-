using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestRegistrationWithParmsStepDefinitions
    {

        private IWebDriver _driver;
        [Given(@"User is on the Registration Page")]
        public void GivenUserIsOnTheRegistrationPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
        }

        [When(@"User Enters ""([^""]*)"", ""([^""]*)"", ""([^""]*)"",""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAnd(string fname, string lname, string addr, string cit, string sta, string zipCode, string phn, string Ssn, string user, string pass, string conPass)
        {
            IWebElement firstName = _driver.FindElement(By.Id("customer.firstName"));
            firstName.SendKeys(fname);

            IWebElement lastName = _driver.FindElement(By.Id("customer.lastName"));
            lastName.SendKeys(lname);

            IWebElement address = _driver.FindElement(By.Id("customer.address.street"));
            address.SendKeys(addr);

            IWebElement city = _driver.FindElement(By.Id("customer.address.city"));
            city.SendKeys(cit);

            IWebElement state = _driver.FindElement(By.Id("customer.address.state"));
            state.SendKeys(sta);

            IWebElement ZipCode = _driver.FindElement(By.Id("customer.address.zipCode"));
            ZipCode.SendKeys(zipCode);

            IWebElement phone = _driver.FindElement(By.Id("customer.phoneNumber"));
            phone.SendKeys(phn);

            IWebElement ssn = _driver.FindElement(By.Id("customer.ssn"));
            ssn.SendKeys(Ssn);

            IWebElement username = _driver.FindElement(By.Id("customer.username"));
            username.SendKeys(user);

            IWebElement password = _driver.FindElement(By.Id("customer.password"));
            password.SendKeys(pass);

            IWebElement confirmPassword = _driver.FindElement(By.Id("repeatedPassword"));
            confirmPassword.SendKeys(conPass);
        }


        [When(@"User Clicks on Register Button")]
        public void WhenUserClicksOnRegisterButton()
        {
            IWebElement submitBtn = _driver.FindElement(By.XPath("//input[@value='Register']"));
            submitBtn.Click();

            Thread.Sleep(3000);
        }

        [Then(@"User is navigated to Registration page")]
        public void ThenUserIsNavigatedToRegistrationPage()
        {
            try
            {

                IWebElement success = _driver.FindElement(By.XPath("//p[contains(text(),'Your account was created successfully. You are now logged in.')]"));
                Console.WriteLine("Account Created succesfully");

                Assert.That(success.Text, Is.EqualTo("Your account was created successfully. You are now logged in."));
            }
            catch
            {
                IWebElement success = _driver.FindElement(By.XPath("//span[@id='customer.username.errors']"));
                Console.WriteLine("Account already exists!!!!");
                Assert.That(success.Text, Is.EqualTo("This username already exists."));
            }
            _driver.Close();
        }
    }
}

using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestLoginWithParamsStepDefinitions
    {
        [When(@"User Enter ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEnterAnd(string username, string password)
        {
            Console.WriteLine(username + "......" + password);
        }

        [Then(@"User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];

                Console.WriteLine(city + "  " + country);
            }
        }

    }

}

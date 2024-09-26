using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestFeatureStepDefinitions
    {
        [Given(@"User is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Test User is on the Login Page");
        }

        [When(@"User Enter username and password")]
        public void WhenUserEnterUsernameAndPassword()
        {
            Console.WriteLine("Test User enters username and password");
        }

        [When(@"User Clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("Test User Clicks on login button");
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("Test User is navigated to home page");
        }
    }
}

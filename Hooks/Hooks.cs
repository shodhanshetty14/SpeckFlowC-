using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public void Setup()
        {
            Console.WriteLine("Before every scenario");
        }

        [AfterScenario]
        public void TearDown()
        {
            Console.WriteLine("After every scenario");
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            TestContext.Progress.WriteLine("TestRun: Running before test");
            //Console.WriteLine("Running before test");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            TestContext.Progress.WriteLine("TestRun : Running after test");
            //Console.WriteLine("Running after test");

        }

        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("Running before Step");
        }

        [AfterStep]
        public void AfterTest()
        {
            Console.WriteLine("Running before Step");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using RestSharpNetCoreTemplate.Helpers;

namespace RestSharpSpecFlowNetCoreTemplate.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReportHelpers.CreateReport();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {

        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            ExtentReportHelpers.AddTest();
        }

        [AfterStep]
        public static void AfterStep()
        {

        }

        [AfterScenario]
        public static void TearDownScenario()
        {
            ExtentReportHelpers.AddTestResult();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentReportHelpers.GenerateReport();
        }
    }
}

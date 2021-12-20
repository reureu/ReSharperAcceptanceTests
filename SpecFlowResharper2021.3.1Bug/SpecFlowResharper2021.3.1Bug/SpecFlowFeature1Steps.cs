using System;
using System.Reflection;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowResharper2021._3._1Bug
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"Let's set some assumptions")]
        public void GivenLetSSetSomeAssumptions()
        {
            var met = MethodBase.GetCurrentMethod();
            ClassLibrary1.Logger.LogMethod(met);
        }

        [When(@"The test is run")]
        public void WhenTheTestIsRun()
        {
            var met = MethodBase.GetCurrentMethod();
            ClassLibrary1.Logger.LogMethod(met);
        }

        [Then(@"the test shall pass")]
        public void ThenTheTestShallPass()
        {
            var met = MethodBase.GetCurrentMethod();
            ClassLibrary1.Logger.LogMethod(met);
            Assert.Pass();
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowLesson.StepDefinitions
{
    [Binding]
    public class StepsValidations
    {
        private readonly ScenarioContext _context;

        public StepsValidations(ScenarioContext context)
        {
            _context = context;
        }
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            var actualResult = (int)_context["result"];
            Assert.AreEqual(expectedResult, actualResult,
                $"Calculation is not working as expected difference is {expectedResult - actualResult}");
        }

    }
}

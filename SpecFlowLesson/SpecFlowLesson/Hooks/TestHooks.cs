using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowLesson.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly Logger _logger;

        public TestHooks()
        {
            _logger = LogManager.GetLogger("*");
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            _logger.Debug(context.ScenarioInfo.Title);

        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext context)
        {
            if (context.ScenarioExecutionStatus != ScenarioExecutionStatus.OK)
            {
                _logger.Error($"Test '{context.ScenarioInfo.Title}' failed: {context.TestError}");
            }
            else
            {
                _logger.Debug($"Test'{context.ScenarioInfo.Title}' is succesfull");
            }
        }

        [BeforeStep]
        public void AfterStep(ScenarioContext context)
        {
            _logger.Info($"Step - {context.StepContext.StepInfo.Text}");

        }
    }
}

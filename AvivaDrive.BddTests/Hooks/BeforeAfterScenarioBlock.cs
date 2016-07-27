using TechTalk.SpecFlow;

namespace AvivaDrive.BddTests.Hooks
{
    [Binding]
    public class BeforeAfterScenarioBlock
    {
        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
        }
    }
}


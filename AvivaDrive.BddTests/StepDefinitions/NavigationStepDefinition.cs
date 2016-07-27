using TechTalk.SpecFlow;
using NUnit.Framework;
using AvivaDrive.BddTests.SystemTasks;
using AvivaDrive.BddTests.Hooks;

namespace AvivaDrive.BddTests.StepDefinitions
{
    [Binding]
    public sealed class NavigationStepDefinition
    {
        public ITasks app_tasks;

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string screen)
        {
            app_tasks = BeforeAfterScenario.app;
            app_tasks.NavigateTo(screen);
        }

        [Then(@"I should be in the ""(.*)"" screen")]
        public void ThenIShouldBeInTheScreen(string expectedScreenTitle)
        {
            Assert.AreEqual(expectedScreenTitle, app_tasks.GetScreenTitle());
        }
    }
}

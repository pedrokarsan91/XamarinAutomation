using TechTalk.SpecFlow;
using Xamarin.UITest;
using AvivaDrive.BddTests.SystemTasks;

namespace AvivaDrive.BddTests.Hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        public static ITasks app;
        static Platform platform;

        [BeforeScenario]
        public void BeforeScenario()
        {
            app = AppInitializer.StartApp(platform);
            app.SkipIntroduction();
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
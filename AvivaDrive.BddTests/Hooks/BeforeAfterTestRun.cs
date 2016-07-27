using TechTalk.SpecFlow;

namespace AvivaDrive.BddTests.Hooks
{
    [Binding]
    public class BeforeAfterTestRun
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
        }
    }
}

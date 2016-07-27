using TechTalk.SpecFlow;

namespace AvivaDrive.BddTests.Hooks
{
    [Binding]
    public class BeforeAfterFeature
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
        }

        [AfterFeature]
        public static void AfterFeature()
        {
        }
    }
}
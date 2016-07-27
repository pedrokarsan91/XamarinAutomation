using Xamarin.UITest;

namespace AvivaDrive.BddTests.SystemTasks
{
    public class IOSTasks : ITasks
    {
        readonly IApp app;

        public IOSTasks(IApp app)
        {
            this.app = app;
        }

        public ITasks Repl()
        {
            app.Repl();
            return this;
        }

        public ITasks SkipIntroduction()
        {
            app.WaitForElement(c => c.Id("acceptButton"));
            app.Tap(c => c.Id("acceptButton"));

            app.WaitForElement(c => c.Id("skipButton"));
            app.Tap(c => c.Id("skipButton"));

            app.WaitForElement(c => c.Id("nextButton"));
            app.Tap(c => c.Id("nextButton"));

            app.WaitForElement(c => c.Id("nextButton"));
            app.Tap(c => c.Id("nextButton"));

            return this;
        }

        public ITasks NavigateTo(string screen)
        {
            OpenMenu();

            TapNavigationMenuItemByText(screen);

            return this;
        }

        public ITasks TapNavigationMenuItemByIndex(int index)
        {
            app.Tap(c => c.Class("NavigationMenuItemView").Index(index));
            return this;
        }

        public ITasks TapNavigationMenuItemByText(string menuItemText)
        {
            app.Tap(c => c.Text(menuItemText));
            return this;
        }


        public ITasks OpenMenu()
        {
            app.Tap(c => c.Id("tbToolbar").Class("ImageButton"));
            return this;
        }

        public string GetScreenTitle()
        {
            app.WaitForElement(c => c.Id("tvTitle"));
            var screenTitle = app.Query(c => c.Id("tvTitle"));
            return screenTitle[0].Text;
        }

    }
}


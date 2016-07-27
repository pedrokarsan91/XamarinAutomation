namespace AvivaDrive.BddTests.SystemTasks
{
    public interface ITasks
    {
        ITasks SkipIntroduction();
        ITasks Repl();
        ITasks TapNavigationMenuItemByText(string screen);
        ITasks TapNavigationMenuItemByIndex(int index);
        ITasks NavigateTo(string screen);
        ITasks OpenMenu();
        string GetScreenTitle();

    }
}


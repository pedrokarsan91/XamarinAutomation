using Xamarin.UITest;
using AvivaDrive.BddTests.SystemTasks;

namespace AvivaDrive.BddTests
{
    public class AppInitializer
    {

        public static ITasks StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return new AndroidTasks(ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .ApkFile(@"../../Binaries/Android/Aviva Drive_com.aviva.ukgi.avivadrive.apk")
                    .StartApp());

            }

            else return new IOSTasks(ConfigureApp
                .iOS
                .StartApp());
        }
    }
}
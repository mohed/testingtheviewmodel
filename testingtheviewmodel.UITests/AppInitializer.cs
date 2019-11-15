using System;
using Xamarin.UITest;

namespace testingtheviewmodel.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.testingtheviewmodel").StartApp();
            }

            if (platform == Platform.iOS)
            {
                return ConfigureApp.iOS.StartApp();
            }

            throw new Exception("Unknown platform");
        }
    }
}
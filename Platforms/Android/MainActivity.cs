using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MauiApp1
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.SmallestScreenSize | ConfigChanges.ScreenLayout | ConfigChanges.ScreenSize
        | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.Locale | ConfigChanges.LayoutDirection | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}

using Android.App;
using Android.Content.PM;
using Android.OS;
using Resource = Microsoft.Maui.Resource;

namespace MauiApp1
{
    [Activity(Theme = "@style/My.Theme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.SmallestScreenSize | ConfigChanges.ScreenLayout | ConfigChanges.ScreenSize
        | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.Locale | ConfigChanges.LayoutDirection | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            //Theme.ApplyStyle(Resource.Style.OptOutEdgeToEdgeEnforcement, force: false);
            base.OnCreate(savedInstanceState);
        }
    }
}

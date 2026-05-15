#if ANDROID
using Android.Graphics.Drawables;
using Android.Views;
using AndroidX.Core.View;
#endif
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Platform;
using Window = Microsoft.Maui.Controls.Window;

namespace MauiApp1Net10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

        }
        protected override void OnStart()
        {
            base.OnStart();
            SetTheme(Application.Current.RequestedTheme);
            RequestedThemeChanged += ThemeChangedEvent;
        }

        private void SetTheme(AppTheme theme)
        {
#if ANDROID
            var darkThemeStatusAndNavbarColor = Microsoft.Maui.Graphics.Color.FromArgb("#72e09a");
            var lightThemeStatusAndNavbarColor = Microsoft.Maui.Graphics.Color.FromArgb("#BCCCDC");
            var activity = Platform.CurrentActivity;
            var window = activity?.Window;
            if (window == null)
                return;
            //window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            //window.ClearFlags(WindowManagerFlags.TranslucentStatus);

            var ac = theme == AppTheme.Dark ? darkThemeStatusAndNavbarColor.ToPlatform() : lightThemeStatusAndNavbarColor.ToPlatform();
            window?.SetBackgroundDrawable(new ColorDrawable(ac));
            //window?.SetStatusBarColor(ac);
            //window?.SetNavigationBarColor(ac);
            var wicc = WindowCompat.GetInsetsController(window, window?.DecorView);
            if (wicc != null)
            {
                wicc.AppearanceLightStatusBars = theme == AppTheme.Dark ? false : true;
                wicc.AppearanceLightNavigationBars = wicc.AppearanceLightStatusBars;
            }
#endif
        }

        private void ThemeChangedEvent(object? sender, AppThemeChangedEventArgs e)
        {
            SetTheme(e.RequestedTheme);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Tabbed());
        }
    }
}
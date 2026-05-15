namespace MauiApp1Net10
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            lblThemeInfo.Text = $"Current Theme: {Application.Current.UserAppTheme}";
        }

        private async void btnOpenModal_Clicked(object sender, EventArgs e)
        {
            var navpage = new NavigationPage(new ModalPage());
            navpage.SetAppThemeColor(NavigationPage.BarBackgroundColorProperty, Color.FromArgb("BCCCDC"), Color.FromArgb("72e09a"));
            await Navigation.PushModalAsync(navpage);
        }

        private void btnToggleTheme_Clicked(object sender, EventArgs e)
        {
            switch (Application.Current.RequestedTheme)
            {
                case AppTheme.Light:
                    Application.Current.UserAppTheme = AppTheme.Dark;
                    lblThemeInfo.Text = $"Current Theme: {Application.Current.UserAppTheme}";
                    break;
                case AppTheme.Dark:
                    {
                        Application.Current.UserAppTheme = AppTheme.Light;
                        lblThemeInfo.Text = $"Current Theme: {Application.Current.UserAppTheme}";
                        break;
                    }
                    //case AppTheme.Unspecified:
                    //    {
                    //        Application.Current.UserAppTheme = AppTheme.Light;
                    //        lblThemeInfo.Text = $"Current Theme: {Application.Current.UserAppTheme}";
                    //        break;
                    //    }
            }

        }
    }
}

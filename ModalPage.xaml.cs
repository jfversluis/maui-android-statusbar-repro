namespace MauiApp1Net10;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        switch (Application.Current.RequestedTheme)
        {
            case AppTheme.Light:
                Application.Current.UserAppTheme = AppTheme.Dark;
                break;
            case AppTheme.Dark:
                {
                    Application.Current.UserAppTheme = AppTheme.Light;
                    break;
                }
                //case AppTheme.Unspecified:
                //    {
                //        Application.Current.UserAppTheme = AppTheme.Light;
                //        lblThemeInfo.Text = $"Current Theme: {Application.Current.UserAppTheme}";
                //        break;

        }
    }
}
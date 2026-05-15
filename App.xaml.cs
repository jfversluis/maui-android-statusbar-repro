using Window = Microsoft.Maui.Controls.Window;

namespace MauiApp1Net10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Tabbed());
        }
    }
}

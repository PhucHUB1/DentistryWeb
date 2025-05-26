using Microsoft.AspNetCore.Components.WebView.Maui;
using DentistryWeb.Services;


namespace DentistryWeb
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var page = new ContentPage
            {
                Content = new BlazorWebView
                {
                    HostPage = "wwwroot/index.html",
                    RootComponents =
            {
                new RootComponent
                {
                    Selector = "#app",
                    ComponentType = typeof(App) // chính là App.razor
                }
            }
                }
            };

            return new Window(page)
            {
                Title = "DentistryWeb"
            };
        }

    }
}

using System;
using Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace NavigationSample
{
    public class App : Application
    {

        public static IHost Host;
        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    //services.AddSingleton<AppState>();
                    services.AddSingleton<MobileNavigationManager>();
                    services.AddSingleton<SampleNavigationManager>();

                    foreach (var service in services)
                    {
                        System.Diagnostics.Debug.WriteLine($"{service.GetType().Name}");
                    }
                })
                .Build();
            MainPage = new ContentPage();
            
            host.AddComponent<AppShell>(parent: this);
            Host = host;
            //var shell = host.Services.GetService<AppShell>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

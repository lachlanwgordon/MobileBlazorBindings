using System;
using System.Collections.Generic;
using System.Text;
using XF = Xamarin.Forms;
using MBB = Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Microsoft.MobileBlazorBindings;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using Microsoft.AspNetCore.Components;

namespace NavigationSample
{
    public class SampleNavigationManager
    {
        XF.Shell XFShell;
        MBB.Elements.Shell MBBShell;


        public SampleNavigationManager(Microsoft.Extensions.Hosting.IHost host)
        {
            if (XFShell == null)
                XFShell = XF.Shell.Current;
            if (MBBShell == null)
                MBBShell = MBB.Elements.Shell.Current;


            XF.Routing.RegisterRoute("secondpage", typeof(SecondPage));

            FindRoutes();
        }

        private void FindRoutes()
        {


            var types = this.GetType().Assembly.GetTypes();
            Debug.WriteLine($"Found types");

            foreach (var type in types)
            {
                Debug.WriteLine($"type: {type.Name} attr: {type.Attributes}");
            }

            foreach (Type type in types)
            {
                if (type.GetCustomAttributes(typeof(RouteAttribute), true).Length > 0)
                {
                     Debug.WriteLine($"Found Page: {type.Name} attr: {type.Attributes}");
                    var attributes = type.GetCustomAttributes(typeof(RouteAttribute), true);
                    foreach (var attribute in attributes)
                    {
                        if(attribute is RouteAttribute route)
                        {
                            Debug.WriteLine($"Found route: {route.Template}");
                            


                            Xamarin.Forms.Routing.RegisterRoute(route.Template, type);
                        }
                    }
                }
            }

        }

        public void NavigateTo(string uri)
        {
            if (XFShell == null)
                XFShell = XF.Shell.Current;
            if (MBBShell == null)
                MBBShell = MBB.Elements.Shell.Current;
            //var contentPage = new XF.ContentPage();

            //var pageRoute = Xamarin.Forms.Routing.GetRoute(uri);
            //var route = Xamarin.Forms.Routing.GetOrCreateContent(uri);


            //XFShell.GoToAsync(uri);
            MBBShell.GoTo(uri);
    
            if(MBBShell.NativeControl == XFShell)
            {
                Debug.WriteLine("Shells are the same, this is good");
            }
            else
            {
                Debug.WriteLine("Shells are not the same, this is bad");

            }

            //App.Host.AddComponent(contentPage);
            //XFShell.Navigation.PushAsync(contentPage);
        }




    }
}

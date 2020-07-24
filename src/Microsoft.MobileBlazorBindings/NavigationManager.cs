using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings
{
    public class MobileNavigationManager
    {
        Xamarin.Forms.Shell XFShell;
        Microsoft.MobileBlazorBindings.Elements.Shell MBBShell;

        public void NavigateTo(string uri)
        {
            if(XFShell == null)
                XFShell = Xamarin.Forms.Shell.Current;
            if (MBBShell == null)
                MBBShell = Elements.Shell.Current;


            MBBShell.GoTo(uri);

            //PageDirective.

        }

        //protected void EnsureInitialized()
        //{
        //    this.Initialize("/", "/");
        //    base.EnsureInitialized();

        //    Shell = Shell.Current;
        //}

        //protected void NavigateToCore(string uri, bool forceLoad)
        //{
        //    Shell.GoToAsync(uri);
        //}
    }
}

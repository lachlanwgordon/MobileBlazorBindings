using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NavigationSample
{
    public class CodedPage : ContentPage
    {
        public CodedPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" },
                    new Label { Text = "Welcome to Xamarin.Forms!" },
                    new Label { Text = "Welcome to Xamarin.Forms!" },
                    new Label { Text = "Welcome to Xamarin.Forms!" },
                    new Label { Text = "Welcome to Xamarin.Forms!" },
                }
            };
        }
    }
}
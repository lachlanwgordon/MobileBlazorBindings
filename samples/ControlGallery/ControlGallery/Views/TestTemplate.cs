using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ControlGallery.Views
{
    public class TestTemplate : ContentView
    {
        public TestTemplate()
        {
            var label = new Label();
            label.SetBinding(Label.TextProperty, ".");

            Content = new StackLayout
            {
                Children = {
                    label
                }


            };
        }
    }
}
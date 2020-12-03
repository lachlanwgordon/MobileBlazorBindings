using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlGallery.Views
{
    public partial class MyTemplate : ComponentBase
    {
        public Microsoft.MobileBlazorBindings.Elements.Label TheLabel { get; set; }


        //public MyTemplate(NativeComponentRenderer)

        public Xamarin.Forms.View GetTemplate()
        {
            var instance = new MyTemplate();



            //var renderer = new NativeComponentRenderer();

            var label = instance.TheLabel;

            var view = label.NativeControl;

            return view;
        }
    }
}

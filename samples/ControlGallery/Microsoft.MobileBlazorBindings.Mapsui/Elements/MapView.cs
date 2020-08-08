using System;
using System.Collections.Generic;
using System.Text;
using Mapsui;
using Mapsui.UI.Objects;
using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Mapsui.Elements.Handlers;
using MF = Mapsui.UI.Forms;

using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Mapsui.Elements
{
    public class MapView : ContentView
    {
        static MapView()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<MapView>(renderer => new MapViewHandler(renderer, new MF.MapView()));
        }

        //[Parameter] public Map Map { get; set; }
        //[Parameter] public IList<Drawable> Drawables { get; set; }
        //[Parameter] public INavigator Navigator { get; set; }

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            //if(Map != null)
            //{
            //    builder.AddAttribute(nameof(Map), Map);
            //}
            //if(Drawables != null)
            //{
            //    builder.AddAttribute(nameof(Drawables), Drawables);
            //}
            //if(Navigator != null)
            //{
            //    builder.AddAttribute(nameof(Navigator), Navigator);
            //}
        }

    }
}

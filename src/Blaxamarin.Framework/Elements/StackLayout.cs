﻿using Blaxamarin.Framework.Elements.Handlers;
using Emblazon;
using Microsoft.AspNetCore.Components;
using XF = Xamarin.Forms;

namespace Blaxamarin.Framework.Elements
{
    public class StackLayout : Element
    {
        static StackLayout()
        {
            ElementHandlerRegistry<IXamarinFormsElementHandler>
                .RegisterElementHandler<StackLayout>(renderer => new StackLayoutHandler(renderer, new XF.StackLayout()));
        }

#pragma warning disable CA1721 // Property names should not match get methods
        [Parameter] public RenderFragment ChildContent { get; set; }
#pragma warning restore CA1721 // Property names should not match get methods
        [Parameter] public XF.StackOrientation? Orientation { get; set; }

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (Orientation != null)
            {
                builder.AddAttribute(nameof(Orientation), (int)Orientation.Value);
            }
        }

        protected override RenderFragment GetChildContent() => ChildContent;

    }
}

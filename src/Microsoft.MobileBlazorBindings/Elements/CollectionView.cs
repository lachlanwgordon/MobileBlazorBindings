using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public class CollectionView<ItemTemplate> : View
    {
        public new XF.CollectionView NativeControl => base.NativeControl as XF.CollectionView;
        static CollectionView()
        {
            ElementHandlerRegistry.RegisterElementHandler<CollectionView<ItemTemplate>>(
                renderer => new CollectionViewHandler<ItemTemplate>(renderer, new XF.CollectionView()));
        }
        [Parameter] public List<string> ItemsSource { get; set; }

        //Serialize everything we know here, so the Handler can put it into the native control
        //"Serialize" means put it in the builder in a weird frame
        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);
            if(ItemsSource != null)
            {
                //Not serializable so do funky things
                builder.AddAttributeReference(nameof(ItemsSource), ItemsSource);
            }
        }
    }
}

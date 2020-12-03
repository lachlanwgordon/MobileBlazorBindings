using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using XF = Xamarin.Forms;
using Microsoft.AspNetCore.Components;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public class CallbackPicker : View
    {
        public new XF.Picker NativeControl => base.NativeControl as XF.Picker;

        static CallbackPicker()
        {
            ElementHandlerRegistry.RegisterElementHandler<CallbackPicker>(renderer => new CallbackPickerHandler(renderer, new XF.Picker()));
        }

        [Parameter] public IList ItemsSource { get; set; }

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if(ItemsSource != null)
            {
                builder.AddAttribute(nameof(ItemsSource), AttributeHelper.IEnumerableToDelegate(ItemsSource));
            }
        }
    }
}

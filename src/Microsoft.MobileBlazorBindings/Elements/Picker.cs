using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public class PickerElement : View
    {
        public new XF.Picker NativeControl => base.NativeControl as XF.Picker;

        static PickerElement()
        {
            ElementHandlerRegistry.RegisterElementHandler<PickerElement>(renderer => new PickerHandler(renderer, new XF.Picker()));
        }
    }
}

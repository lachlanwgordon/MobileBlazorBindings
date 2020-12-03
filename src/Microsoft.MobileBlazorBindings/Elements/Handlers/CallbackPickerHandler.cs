using System;
using System.Collections.Generic;
using System.Text;
using XF = Xamarin.Forms;
using MBB = Microsoft.MobileBlazorBindings.Elements;
using Xamarin.Forms;
using Microsoft.MobileBlazorBindings.Core;

namespace Microsoft.MobileBlazorBindings.Elements.Handlers
{
    public class CallbackPickerHandler : ViewHandler
    {
        public CallbackPickerHandler(NativeComponentRenderer renderer, XF.Picker pickerControl) : base(renderer, pickerControl)
        {
            PickerControl = pickerControl;
        }
        public Picker PickerControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch(attributeName)
            {
                case nameof(Picker.ItemsSource):
                    PickerControl.ItemsSource = AttributeHelper.DelegateToIList(attributeValue);
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;

            }

        }
    }
}

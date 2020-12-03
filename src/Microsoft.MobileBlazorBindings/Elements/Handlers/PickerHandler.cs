using System;
using System.Collections;
using System.Text;
using Xamarin.Forms;
using XF = Xamarin.Forms;
using MBB = Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Core;

namespace Microsoft.MobileBlazorBindings.Elements.Handlers
{
    public partial class PickerHandler : ViewHandler
    {
        public PickerHandler(NativeComponentRenderer renderer, XF.Picker pickerControl) : base(renderer, pickerControl)
        {
            PickerControl = pickerControl;
        }

        public XF.Picker PickerControl { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.AspNetCore.Components.Rendering;

namespace ControlGallery.Views
{
    public partial class ManualPicker : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent<PickerElement>(0);
            builder.AddComponentReferenceCapture(1, (value) => {
                ThePicker = (PickerElement)value;
            }
            );
            builder.CloseComponent();
        }

        public PickerElement ThePicker { get; set; }

        [Parameter]
        public IList ItemsSource { get; set; }


        protected override void OnAfterRender(bool firstRender)
        {
            if (ItemsSource != null)
            {
                ThePicker.NativeControl.ItemsSource = ItemsSource;
            }
        }
    }
}

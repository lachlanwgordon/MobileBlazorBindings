using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.SkiaSharp.Elements.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using SK = SkiaSharp.Views.Forms;

namespace Microsoft.MobileBlazorBindings.SkiaSharp.Elements
{
    public class SKCanvasView : View
    {
        static SKCanvasView()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<SKCanvasView>(renderer => new SKCanvasViewHandler(renderer, new SK.SKCanvasView()));
        }

        
    }
}

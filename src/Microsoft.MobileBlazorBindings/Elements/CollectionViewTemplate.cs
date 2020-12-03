using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public class CollectionViewTemplate : NativeControlComponentBase
    {
        [Parameter] public string TemplateType { get; set; }

    }
}

// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Mapsui;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using MF = Mapsui.UI.Forms;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Mapsui.Elements.Handlers
{
    public class MapViewHandler : ContentViewHandler
    {
        public MapViewHandler(NativeComponentRenderer renderer, MF.MapView mapViewControl) : base(renderer, mapViewControl)
        {
            MapViewControl = mapViewControl;
        }
        public MF.MapView MapViewControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch(attributeName)
            {
                case nameof(MF.MapView.Map):
                    MapViewControl.Map = attributeValue as Map;
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
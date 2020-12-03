using Microsoft.MobileBlazorBindings.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XF = Xamarin.Forms;
using MBB = Microsoft.MobileBlazorBindings.Elements;
using Microsoft.AspNetCore.Components;

namespace Microsoft.MobileBlazorBindings.Elements.Handlers
{
    public partial class CollectionViewHandler<ItemTemplate> : ViewHandler//, INonPhysicalParent
    {
        public CollectionViewHandler(NativeComponentRenderer renderer, XF.CollectionView collectionViewControl) : base(renderer, collectionViewControl)
        {
            CollectionViewControl = collectionViewControl;
            CollectionViewControl.ItemTemplate = new DataTemplate(typeof(ItemTemplate));
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public XF.CollectionView CollectionViewControl { get; }

        //Deserialize the MBB version and put it in the native control
        //each call to the
        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(CollectionView.ItemsSource):
                    CollectionViewControl.ItemsSource = AttributesBuilder.GetAttributeReference((string)attributeValue) as IEnumerable;
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}

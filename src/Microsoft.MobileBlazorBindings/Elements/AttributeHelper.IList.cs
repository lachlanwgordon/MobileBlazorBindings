﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public static partial class AttributeHelper
    {
        public static AttributeValueHolder IListToDelegate(IList itemsSource)
        {
            if(itemsSource is null)
            {
                throw new ArgumentNullException(nameof(itemsSource));
            }

            return AttributeValueHolderFactory.FromObject(itemsSource);
        }

        public static IList DelegateToIList(object itemsSource, IList defaultValueIfNull = default)
        {
            return AttributeValueHolderFactory.ToValue<IList>(itemsSource, defaultValueIfNull);
        }

    }
}

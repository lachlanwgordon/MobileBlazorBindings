using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public static partial class AttributeHelper
    {
        public static AttributeValueHolder IEnumerableToDelegate(IEnumerable itemsSource)
        {
            if(itemsSource is null)
            {
                throw new ArgumentNullException(nameof(itemsSource));
            }

            return AttributeValueHolderFactory.FromObject(itemsSource);
        }

        public static IEnumerable DelegateToIEnumerable(object itemsSource, IEnumerable defaultValueIfNull = default)
        {
            return AttributeValueHolderFactory.ToValue<IEnumerable>(itemsSource, defaultValueIfNull);
        }

    }
}

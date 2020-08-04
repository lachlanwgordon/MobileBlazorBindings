using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileBlazorBindingsHelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleXamlPage : ContentPage
    {
        public SampleXamlPage()
        {
            InitializeComponent();
        }
    }
}
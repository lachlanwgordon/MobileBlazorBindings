using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MBB = Microsoft.MobileBlazorBindings;
using XF = Xamarin.Forms;
using Xamarin.Forms;
using Microsoft.MobileBlazorBindings;
using System.Threading.Tasks;

namespace ControlGallery.Views
{
    public partial class CollectionViewPlayground : ComponentBase
    {
        [Inject] public IServiceProvider Services {get;set;}

        //public MBB.Elements.CollectionView TheCollectionView { get; set; }

        

        public async Task ButtonClicked()
        {

            //This works, but it's not very blazory
            //TheCollectionView.NativeControl.ItemsSource = Items;

            var type = typeof(MyTemplate);

            //var templates = new Stack<XF.View>();
            //for( int i = 0; i < 20; i++)
            //{
            //    //var comp = await Services.AddComponent(TheCollectionView.NativeControl, type);

            //    var mytemplate = comp as MyTemplate;
            //    var mLabel = mytemplate.TheLabel;
            //    var xlabel = mLabel.NativeControl;

            //    templates.Push(xlabel);
            //}

            ////var xTemplate = mtemplate.NativeControl;

            //TheCollectionView.NativeControl.ItemTemplate = new DataTemplate( () =>
            //{
            //    //var label = new XF.Label { Text = "Test" };
            //    //label.SetBinding(XF.Label.TextProperty, ".");

            //    return templates.Pop() ;
            //});
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}

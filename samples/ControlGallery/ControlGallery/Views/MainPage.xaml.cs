using Mapsui.UI.Forms;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mapsui;
using Mapsui.Geometries;
using Mapsui.Projection;
using Mapsui.Utilities;



namespace ControlGallery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var circle = new Circle
            {
                Center = new Position(-37, 145),
                Radius = Distance.FromKilometers(5),
                Quality = 50,
                StrokeColor = new Color(1, 0, 0),
                FillColor = new Color(0.5, 0.5, 0, 0.5),

            };
            mapView.Drawables.Add(circle);
            var min = new Position(-35, 144).ToMapsui();
            var max = new Position(-37, 145).ToMapsui();
            var box = new BoundingBox(max, min);
            mapView.Navigator.NavigateTo(box);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var map = new Map
            {
                CRS = "EPSG:3857",
                Transformation = new MinimalTransformation()
            };

            var tileLayer = OpenStreetMap.CreateTileLayer();

            map.Layers.Add(tileLayer);
            map.Widgets.Add(new Mapsui.Widgets.ScaleBar.ScaleBarWidget(map) { TextAlignment = Mapsui.Widgets.Alignment.Center, HorizontalAlignment = Mapsui.Widgets.HorizontalAlignment.Left, VerticalAlignment = Mapsui.Widgets.VerticalAlignment.Bottom });


            mapView.Map = map;


        }

        void OnClick()
        {

        }
    }
}
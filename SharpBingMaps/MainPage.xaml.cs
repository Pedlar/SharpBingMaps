using System;
using SharpBingMaps.Controller;
using SharpBingMaps.Controllers;
using SharpBingMaps.Interfaces;
using SharpBingMaps.Network.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace SharpBingMaps {
    public sealed partial class MainPage : Page, IMainView {
        public string MapsAPIKey {
            get { return Creds.API_KEY; }
        }

        private MapController mapController;

        public MainPage() {
            this.InitializeComponent();
            //TODO: Need to look more into how the code for the XAML stuff is Auto-Generated and if there is any
            //      Dependency Injection tools already in place. This should be passed in the Constructor, but because
            //      That's auto-gen I don't know how to fit that in yet. Looking at Autofac but haven't seen XAML
            //      examples yet.
            mapController = new MapController();

            mapController.SetView(this);
        }

        public void MapLoaded(object sender, RoutedEventArgs routedEventArgs) {
            mapController.SetMapControls(mMap);
            mapController.SetSceneToEugeneFriendly();
        }

        public void MapClick(MapControl sender, MapInputEventArgs mapInputEventArgs) {
            mapController.HandleMapClicked(mapInputEventArgs);
        }

        public async void LookupAddressOnClick(object sender, RoutedEventArgs routedEventArgs) {

        }

        public void SetStatusText(string status) {
            StatusBlock.Text = status;
        }
    }

    public interface IMyResource {

    }
}

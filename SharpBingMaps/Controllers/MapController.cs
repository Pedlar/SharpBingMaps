using SharpBingMaps.Interfaces;
using System;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

namespace SharpBingMaps.Controllers {
    class MapController {
        private IMainView mainView;
        private MapControl mapControls;

        public MapController() {

        }

        public void SetView(IMainView mainView) {
            this.mainView = mainView;
        }

        public void SetMapControls(MapControl mapControls) {
            this.mapControls = mapControls;
        }

        public void HandleMapClicked(MapInputEventArgs args) {
            BasicGeoposition tappedGeoPosition = args.Location.Position;
            string status = "MapTapped at Latitude: " + tappedGeoPosition.Latitude + ", Longitude: " + tappedGeoPosition.Longitude;

            mainView.SetStatusText(status);
        }

        public async void SetGeopointAsync(Geopoint geopoint) {
            mapControls.Center = geopoint ?? throw new ArgumentNullException(nameof(geopoint));
            MapScene mapScene = MapScene.CreateFromLocationAndRadius(mapControls.Center, 9001);
            await mapControls.TrySetSceneAsync(mapScene);
        }

        public void SetSceneToAustin() {
            SetGeopointAsync(new Geopoint(new BasicGeoposition() { Latitude = 30.2642, Longitude = -97.7476 }));
        }

        public void SetSceneToEugeneFriendly() {
            SetGeopointAsync(new Geopoint(new BasicGeoposition() { Latitude = 44.033, Longitude = -123.111 }));
        }
    }
}

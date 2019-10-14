using SharpBingMaps.Network.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SharpBingMaps.Controller {
    public class LocationService {
        private const string basePath = "http://dev.virtualearth.net/REST/v1/Locations/US/";
        private readonly HttpClient httpClient;

        public LocationService() {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(basePath);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<LocationDataResourceWrapper> GetAddress(
            string adminDistrict, 
            string locality, 
            int postalCode, 
            string addressLine) {

            string path = $"{adminDistrict}/{postalCode}/{locality}/{addressLine}?key={Creds.API_KEY}";

            LocationDataResourceWrapper locationDataResourceWrapper = null;
            HttpResponseMessage response = await httpClient.GetAsync(path);

            if (response.IsSuccessStatusCode) {
                locationDataResourceWrapper = await response.Content.ReadAsAsync<LocationDataResourceWrapper>();
            }

            return locationDataResourceWrapper;
        }
    }
}

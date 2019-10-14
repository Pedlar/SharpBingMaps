using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBingMaps.Network.Models {
    public class ResourceSet {
        public int estimatedTotal { get; set; }
        public List<LocationResource> resources { get; set; }
    }

    public class LocationDataResourceWrapper {
        public string authenticationResultCode { get; set; }
        public string brandLogoUri { get; set; }
        public string copyright { get; set; }
        public List<ResourceSet> resourceSets { get; set; }
        public int statusCode { get; set; }
        public string statusDescription { get; set; }
        public string traceId { get; set; }
    }
}

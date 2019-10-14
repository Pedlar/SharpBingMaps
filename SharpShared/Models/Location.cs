
namespace SharpShared.Models {
    public class Location {
        public string name { get; }
        public Coordinates coordinates { get; }

        public Location(string name, double Latitude, double Longitude) {
            this.name = name;
            this.coordinates = new Coordinates(Latitude, Longitude);
        }
    }
}

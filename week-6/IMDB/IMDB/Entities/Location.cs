using System.Collections.Generic;

namespace IMDB.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public ICollection<LocationMovie> MovieLocations { get; set; }
    }
}

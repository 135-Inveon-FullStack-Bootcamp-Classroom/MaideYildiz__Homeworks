using System;
using System.Collections.Generic;

namespace IMDB_clone.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Crew> MovieActors { get; set; }
        public ICollection<Location> MovieLocations { get; set; }
        public ICollection<Review> MovieReviews { get; set; }
    }
}

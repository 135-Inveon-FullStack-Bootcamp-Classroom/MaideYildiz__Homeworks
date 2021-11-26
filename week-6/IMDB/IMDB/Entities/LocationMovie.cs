namespace IMDB.Entities
{
    public class LocationMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie movie { get; set; }
        public int LocationId { get; set; }
        public Location location { get; set; }
    }
}

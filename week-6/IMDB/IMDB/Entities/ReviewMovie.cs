namespace IMDB.Entities
{
    public class ReviewMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie movie { get; set; }
        public int ReviewId { get; set; }
        public Review review { get; set; }
    }
}

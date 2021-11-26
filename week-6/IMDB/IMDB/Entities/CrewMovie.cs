namespace IMDB.Entities
{
    public class CrewMovie
    {
        public int Id { get; set; } 
        public int MovieId { get; set; }
        public Movie movie { get; set; }
        public int CrewId { get; set; }
        public Crew crew { get; set; }
    }
}

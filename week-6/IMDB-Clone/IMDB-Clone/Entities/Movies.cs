namespace IMDB_Clone.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string[] Genre { get; set; }
    }
}

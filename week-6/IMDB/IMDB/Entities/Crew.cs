using System.Collections.Generic;

namespace IMDB.Entities
{
    public class Crew
    {
        public int CrewID { get; set; }
        public enum CrewType
        {
            writer,
            actor,
            director
        }
        public string CrewName { get; set; }
        public string CrewSurname { get; set; }
        public int CrewAge { get; set; }
        public string CrewBio { get; set; }
        public IList<Movie> MovieActors { get; set; }
    }
}

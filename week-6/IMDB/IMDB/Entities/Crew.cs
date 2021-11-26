using System.Collections.Generic;

namespace IMDB.Entities
{
    public class Crew
    {
        public int CrewID { get; set; }
        public enum CrewType
        {
            writer = 0,
            actor = 1,
            director = 2
        }
        public string CrewName { get; set; }
        public string CrewSurname { get; set; }
        public int CrewAge { get; set; }
        public string CrewBio { get; set; }
        public ICollection<CrewMovie> MovieActors { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace IMDB.Entities
{
    public class Actor : ICrew
    {
        [Key]
        public int CrewID { get; set; }
        public string CrewName { get; set; }
        public string CrewSurname { get; set; }
        public int CrewAge { get ; set ; }
        public string CrewBio { get ; set ; }
        public IList<MovieActor> MovieActors { get; set; }
    }
}

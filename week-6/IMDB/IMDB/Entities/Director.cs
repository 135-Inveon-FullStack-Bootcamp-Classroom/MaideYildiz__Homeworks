using System.ComponentModel.DataAnnotations;

namespace IMDB.Entities
{
    public class Director:ICrew
    {
        [Key]
        public int CrewID { get; set; }
        public string CrewName { get; set; }
        public string CrewSurname { get; set; }
        public int CrewAge { get; set; }
        public string CrewBio { get; set; }
    }
}

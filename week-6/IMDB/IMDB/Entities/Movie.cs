using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IMDB.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<MovieActor> MovieActors { get; set; }
    }
}

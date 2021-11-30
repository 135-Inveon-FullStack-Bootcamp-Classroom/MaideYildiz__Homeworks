﻿using System.Collections.Generic;

namespace IMDB_clone.Entities
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewPerson { get; set; }
        public string ReviewText { get; set; }
        public ICollection<Movie> MovieReviews { get; set; }
    }
}

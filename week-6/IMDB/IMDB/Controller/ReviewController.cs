using IMDB;
using IMDB.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public ReviewController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var reviews = _dbContext.Review.ToList();
            return Ok(reviews);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var reviews = _dbContext.Review.ToList();
            var idReview = reviews[0];
            foreach (var r in reviews)
            {
                if (r.ReviewID == id)
                {
                    idReview = r;
                }
            }
            return Ok(idReview);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Review review)
        {
            _dbContext.Review.Add(review);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Review review)
        {
            var reviews = _dbContext.Review.ToList();
            var idReview = reviews[0];
            foreach (var r in reviews)
            {
                if (r.ReviewID == id)
                {
                    idReview = r;
                }
            }
            idReview.ReviewPerson = review.ReviewPerson;
            idReview.ReviewText = review.ReviewText;
            idReview.MovieReviews = review.MovieReviews;
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reviews = _dbContext.Review.ToList();
            var idReview = reviews[0];
            foreach (var r in reviews)
            {
                if (r.ReviewID == id)
                {
                    idReview = r;
                    _dbContext.Review.Remove(idReview);
                    _dbContext.SaveChanges();
                }
            }
            return Ok();
        }
    }
}

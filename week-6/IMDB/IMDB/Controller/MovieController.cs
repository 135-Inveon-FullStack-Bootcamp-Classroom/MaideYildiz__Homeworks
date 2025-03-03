﻿using IMDB;
using IMDB.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public MovieController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IActionResult Get()
        {
            var movies = _dbContext.Movies.ToList();
            return Ok(movies);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var movies = _dbContext.Movies.ToList();
            var idMovie= movies[0];
            foreach (var movie in movies)
            {
                if(movie.Id == id)
                {
                    idMovie = movie;
                }
            }
            return Ok(idMovie);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return Ok();
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie movie)
        {
            var movies = _dbContext.Movies.ToList();
            var idMovie = movies[0];
            foreach (var m in movies)
            {
                if (m.Id == id)
                {
                    idMovie = m;
                }
            }
            idMovie.Name = movie.Name;
            idMovie.Description = movie.Description;
            idMovie.CreatedDate= movie.CreatedDate;
            idMovie.MovieActors = movie.MovieActors;
            idMovie.MovieLocations=movie.MovieLocations;
            idMovie.MovieReviews = movie.MovieReviews;
            _dbContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movies = _dbContext.Movies.ToList();
            var idMovie = movies[0];
            foreach (var movie in movies)
            {
                if (movie.Id == id)
                {
                    idMovie = movie;
                    _dbContext.Movies.Remove(idMovie);
                    _dbContext.SaveChanges();
                }
            }
            return Ok();
        }
    }
}

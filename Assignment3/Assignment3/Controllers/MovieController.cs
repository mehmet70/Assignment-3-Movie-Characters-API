using Assignment3.Models;
using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieCharacterDbContext _context;
        private readonly IMapper _mapper;

        public MovieController(MovieCharacterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieReadDTO>>> GetMovies()
        {
            var movies = await _context.Movies.ToListAsync();

            var moviesToSend = _mapper.Map<List<MovieReadDTO>>(movies);

            return Ok(moviesToSend);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieReadDTO>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            
            if (movie == null)
            {
                return NotFound();
            }

            var movieToSend = _mapper.Map<MovieReadDTO>(movie);

            return Ok(movieToSend);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Movie>> PutMovie(int id, [FromBody] Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoviesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<MovieReadDTO>> PostMovie([FromBody] MovieCreateDTO movie)
        {
            var domainMovie = _mapper.Map<Movie>(movie);

            _context.Movies.Add(domainMovie);

            await _context.SaveChangesAsync();

            var movieToSend = _mapper.Map<MovieReadDTO>(domainMovie);

            return CreatedAtAction("GetMovie", new { id = domainMovie.Id }, movieToSend);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MoviesExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}

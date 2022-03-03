using Assignment3.Models;
using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Character;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class MovieController : ControllerBase
    {
        private readonly MovieCharacterDbContext _context;
        private readonly IMapper _mapper;

        public MovieController(MovieCharacterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all movies from the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<MovieReadDTO>>> GetMovies()
        {
            var movies = await _context.Movies.Include(m => m.Characters).ToListAsync();

            var moviesToSend = _mapper.Map<List<MovieReadDTO>>(movies);

            return Ok(moviesToSend);
        }

        /// <summary>
        /// Get a specific movie from the database by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>P</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<MovieReadDTO>> GetMovie(int id)
        {
            var movie = await _context.Movies.Include(m => m.Characters).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var movieToSend = _mapper.Map<MovieReadDTO>(movie);

            return Ok(movieToSend);
        }

        /// <summary>
        /// Gets all characters from a specific movie specified by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/characters")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<List<CharacterReadDTO>>> GetCharactersInMovie(int id)
        {
            var movie = await _context.Movies.Include(m => m.Characters).ThenInclude(c => c.Movies).SingleOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var charactersToSend = _mapper.Map<List<CharacterReadDTO>>(movie.Characters);

            return Ok(charactersToSend);
        }

        /// <summary>
        /// Updates a movie in the database.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> PutMovie(int id, [FromBody] MovieUpdateDTO movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            var domainMovie = _mapper.Map<Movie>(movie);

            _context.Entry(domainMovie).State = EntityState.Modified;

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

        /// <summary>
        /// Adds a new movie to the database
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<ActionResult<MovieReadDTO>> PostMovie([FromBody] MovieCreateDTO movie)
        {
            var domainMovie = _mapper.Map<Movie>(movie);

            _context.Movies.Add(domainMovie);

            await _context.SaveChangesAsync();

            var movieToSend = _mapper.Map<MovieReadDTO>(domainMovie);

            return CreatedAtAction("GetMovie", new { id = domainMovie.Id }, movieToSend);
        }

        /// <summary>
        /// Deletes a movie from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
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

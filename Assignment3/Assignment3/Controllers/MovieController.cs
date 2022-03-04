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

        #region Get

        /// <summary>
        /// Get all movies from the database.
        /// </summary>
        /// <returns>A list of all movies in the database and a responsetype indicating success.</returns>
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
        /// <param name="id">Movie ID</param>
        /// <returns>A movie from the database and a responsetype indicating whether the movie was found.</returns>
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
        /// <param name="id">Movie ID</param>
        /// <returns>A list of characters from the database and a responsetype indicating success.</returns>
        [HttpGet("{id}/characters")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<List<CharacterReadDTO>>> GetCharactersInMovie(int id)
        {
            var movie = await _context.Movies.Include(m => m.Characters).ThenInclude(c => c.Movies).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var charactersToSend = _mapper.Map<List<CharacterReadDTO>>(movie.Characters);

            return Ok(charactersToSend);
        }

        #endregion

        #region Put

        /// <summary>
        /// Updates a movie in the database.
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <param name="movie">The movie data to update.</param>
        /// <returns>A responsetype indicating success and whether the movie was found.</returns>
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
        /// Updates the characters in a movie.
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <param name="characterIds">The IDs of characters to update in the movie.</param>
        /// <returns>A responsetype indicating success and whether the movie and characters were found.</returns>
        [HttpPut("{id}/characters")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateCharactersInMovie(int id, [FromBody] List<int> characterIds)
        {
            var movie = await _context.Movies.Include(m => m.Characters).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            // Update the characters in the movie
            movie.Characters = new List<Character>();

            foreach (var characterId in characterIds)
            {
                var character = await _context.Characters.FindAsync(characterId);

                if (character == null)
                {
                    return NotFound();
                }

                movie.Characters.Add(character);
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion

        #region Post

        /// <summary>
        /// Adds a new movie to the database
        /// </summary>
        /// <param name="movie">The movie data to add to the database.</param>
        /// <returns>A movie ID, movie data and a responsetype indicating success.</returns>
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

        #endregion

        #region Delete

        /// <summary>
        /// Deletes a movie from the database.
        /// </summary>
        /// <param name="id">Movie ID</param>
        /// <returns>A responsetype indicating success and whether the movie was found.</returns>
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

        #endregion

        /// <summary>
        /// Checks if a movie exists in the database.
        /// </summary>
        /// <param name="id">An integer representing the movie ID.</param>
        /// <returns>A boolean indicating whether the movie exists in the database.</returns>
        private bool MoviesExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}

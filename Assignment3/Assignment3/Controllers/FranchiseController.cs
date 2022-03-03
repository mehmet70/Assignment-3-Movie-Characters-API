﻿using Assignment3.Models;
using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Character;
using Assignment3.Models.DTOs.Franchise;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class FranchiseController : ControllerBase
    {
        private readonly MovieCharacterDbContext _context;
        private readonly IMapper _mapper;

        public FranchiseController(MovieCharacterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region Get

        /// <summary>
        /// Get all franchises in the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<FranchiseReadDTO>>> GetFranchises()
        {
            var franchises = await _context.Franchises.Include(f => f.Movies).ToListAsync();

            var franchisesToSend = _mapper.Map<List<FranchiseReadDTO>>(franchises);

            return Ok(franchisesToSend);
        }

        /// <summary>
        /// Get a specific franchise from the database by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<FranchiseReadDTO>> GetFranchise(int id)
        {
            var franchise = await _context.Franchises.Include(f => f.Movies).FirstOrDefaultAsync(f => f.Id == id);

            if (franchise == null)
            {
                return NotFound();
            }

            var franchiseToSend = _mapper.Map<FranchiseReadDTO>(franchise);

            return Ok(franchiseToSend);
        }

        /// <summary>
        /// Gets all movies from a specific franchise specified by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/movies")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<List<MovieReadDTO>>> GetMoviesInFranchise(int id)
        {
            var franchise = await _context.Franchises.Include(f => f.Movies).FirstOrDefaultAsync(f => f.Id == id);

            if (franchise == null)
            {
                return NotFound();
            }

            var moviesToSend = _mapper.Map<List<MovieReadDTO>>(franchise.Movies);

            return Ok(moviesToSend);
        }

        /// <summary>
        /// Gets all characters from a specific franchise specified by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/characters")]
        public async Task<ActionResult<CharacterReadDTO>> GetCharactersInFranchise(int id)
        {
            var franchise = await _context.Franchises.Include(f => f.Movies).ThenInclude(m => m.Characters).FirstOrDefaultAsync(f => f.Id == id);

            if (franchise == null)
            {
                return NotFound();
            }

            List<Character> characters = new List<Character>();
            foreach (var movie in franchise.Movies)
            {
                characters.AddRange(movie.Characters);
            }

            var charactersToSend = _mapper.Map<List<CharacterReadDTO>>(characters.Distinct()).OrderBy(c => c.Id);

            return Ok(charactersToSend);
        }

        #endregion

        #region Put

        /// <summary>
        /// Updates a franchise in the database.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="franchise"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> PutFranchise(int id, [FromBody] FranchiseUpdateDTO franchise)
        {
            if (id != franchise.Id)
            {
                return BadRequest();
            }

            var domainFranchise = _mapper.Map<Franchise>(franchise);

            _context.Entry(domainFranchise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FranchiseExists(id))
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
        /// Updates the movies in a franchise.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movieIds"></param>
        /// <returns></returns>
        [HttpPut("{id}/movies")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateMoviesInFranchise(int id, [FromBody] List<int> movieIds)
        {
            var franchise = await _context.Franchises.Include(f => f.Movies).FirstOrDefaultAsync(f => f.Id == id);

            if (franchise == null)
            {
                return NotFound();
            }

            franchise.Movies = new List<Movie>();
            
            foreach (var movieId in movieIds)
            {
                var movie = await _context.Movies.FindAsync(movieId);

                if (movie == null)
                {
                    return NotFound();
                }

                franchise.Movies.Add(movie);
            }
            
            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        #endregion

        #region Post

        /// <summary>
        /// Adds a new franchise to the database.
        /// </summary>
        /// <param name="franchise"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<ActionResult<FranchiseReadDTO>> PostFranchise([FromBody] FranchiseCreateDTO franchise)
        {
            var domainFranchise = _mapper.Map<Franchise>(franchise);

            _context.Franchises.Add(domainFranchise);
            
            await _context.SaveChangesAsync();

            var franchiseToSend = _mapper.Map<FranchiseReadDTO>(domainFranchise);

            return CreatedAtAction("GetFranchise", new { id = domainFranchise.Id }, franchiseToSend);
        }

        #endregion

        #region Delete

        /// <summary>
        /// Deletes a franchise from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> DeleteFranchise(int id)
        {
            var franchise = await _context.Franchises.FindAsync(id);
            if (franchise == null)
            {
                return NotFound();
            }

            _context.Franchises.Remove(franchise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        #endregion

        private bool FranchiseExists(int id)
        {
            return _context.Franchises.Any(e => e.Id == id);
        }
    }
}

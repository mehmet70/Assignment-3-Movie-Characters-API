using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using Assignment3.Models.Domain;
using AutoMapper;
using Assignment3.Models.DTOs.Character;
using System.Net.Mime;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class CharacterController : ControllerBase
    {
        private readonly MovieCharacterDbContext _context;
        private readonly IMapper _mapper;

        public CharacterController(MovieCharacterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all characters from the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<CharacterReadDTO>>> GetCharacters()
        {
            var characters = await _context.Characters.ToListAsync<Character>();

            var charactersToSend = _mapper.Map<List<CharacterReadDTO>>(characters);

            return Ok(charactersToSend);
        }

        /// <summary>
        /// Get a specific character from the database by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<CharacterReadDTO>> GetCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            CharacterReadDTO characterToSend = _mapper.Map<CharacterReadDTO>(character);

            return Ok(characterToSend);
        }

        /// <summary>
        /// Updates a character in the database.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="character"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> PutCharacter(int id, [FromBody] CharacterUpdateDTO character)
        {
            if (id != character.Id)
            {
                return BadRequest();
            }

            var domainCharacter = _mapper.Map<Character>(character);

            _context.Entry(domainCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
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
        /// Adds a new character to the database.
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<ActionResult<CharacterReadDTO>> PostCharacter([FromBody] CharacterCreateDTO character)
        {
            var domainCharacter = _mapper.Map<Character>(character);

            _context.Characters.Add(domainCharacter);

            await _context.SaveChangesAsync();

            var characterToSend = _mapper.Map<CharacterReadDTO>(domainCharacter);

            return CreatedAtAction("GetCharacter", new { id = domainCharacter.Id }, characterToSend);
        }

        /// <summary>
        /// Deletes a character from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.Id == id);
        }
    }
}

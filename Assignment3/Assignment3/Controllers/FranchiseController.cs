using Assignment3.Models;
using Assignment3.Models.Domain;
using Assignment3.Models.DTOs.Franchise;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FranchiseController : ControllerBase
    {
        private readonly MovieCharacterDbContext _context;
        private readonly IMapper _mapper;

        public FranchiseController(MovieCharacterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FranchiseReadDTO>>> GetFranchises()
        {
            var franchises = await _context.Franchises.ToListAsync();

            var franchisesToSend = _mapper.Map<List<FranchiseReadDTO>>(franchises);

            return Ok(franchisesToSend);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FranchiseReadDTO>> GetFranchise(int id)
        {
            var franchise = await _context.Franchises.FindAsync(id);

            if (franchise == null)
            {
                return NotFound();
            }

            var franchiseToSend = _mapper.Map<FranchiseReadDTO>(franchise);

            return Ok(franchiseToSend);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Franchise>> PutFranchise(int id, [FromBody] Franchise franchise)
        {
            if (id != franchise.Id)
            {
                return BadRequest();
            }

            _context.Entry(franchise).State = EntityState.Modified;

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

        [HttpPost]
        public async Task<ActionResult<FranchiseReadDTO>> PostFranchise([FromBody] FranchiseCreateDTO franchise)
        {
            var domainFranchise = _mapper.Map<Franchise>(franchise);

            _context.Franchises.Add(domainFranchise);
            
            await _context.SaveChangesAsync();

            var franchiseToSend = _mapper.Map<FranchiseReadDTO>(domainFranchise);

            return CreatedAtAction("GetFranchise", new { id = domainFranchise.Id }, franchiseToSend);
        }

        [HttpDelete("{id}")]
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

        private bool FranchiseExists(int id)
        {
            return _context.Franchises.Any(e => e.Id == id);
        }
    }
}

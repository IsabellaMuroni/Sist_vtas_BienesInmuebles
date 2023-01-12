using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Context;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmuebleController : ControllerBase
    {
        private InmuebleContext _context;

        public InmuebleController(InmuebleContext context)
        {
            _context = context;
        }

        [HttpGet]
        //public IEnumerable<Cliente> GetClientes() => _context.Clientes.ToList();
        public async Task<List<Inmueble>> GetInmueblesAsync()
        {
            return await _context.Inmuebles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Inmueble>> GetInmueble(int id)
        {
            var inmueble = await _context.Inmuebles.FindAsync(id);

            if (inmueble == null)
            {
                return NotFound();
            }

            return inmueble;
        }

        [HttpPost]
        public async Task CreateInmueble(Inmueble inmueble)
        {
            _context.Inmuebles.Add(inmueble);
            await _context.SaveChangesAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditInmueble(int id, Inmueble inmueble)
        {
            if (id != inmueble.Id_Inmueble)
            {
                return BadRequest();
            }

            _context.Entry(inmueble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InmuebleExists(id))
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

        private bool InmuebleExists(int id)
        {
            return _context.Inmuebles.Any(e => e.Id_Inmueble == id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInmueble(int id)
        {
            var inmueble = await _context.Clientes.FindAsync(id);
            if (inmueble == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(inmueble);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}

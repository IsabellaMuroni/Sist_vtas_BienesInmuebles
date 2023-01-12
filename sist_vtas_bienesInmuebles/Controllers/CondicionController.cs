using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Context;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondicionController : ControllerBase
    {
        private InmuebleContext _context;

        public CondicionController(InmuebleContext context)
        {
            _context = context;
        }

        [HttpGet]
        //public IEnumerable<Cliente> GetClientes() => _context.Clientes.ToList();
        public async Task<List<Condicion>> GetCondicionesAsync()
        {
            return await _context.Condiciones.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Condicion>> GetCondicion(int id)
        {
            var condicion = await _context.Condiciones.FindAsync(id);

            if (condicion == null)
            {
                return NotFound();
            }

            return condicion;
        }

        [HttpPost]
        public async Task CreateCondicion(Condicion nuevaCondicion)
        {
            _context.Condiciones.Add(nuevaCondicion);
            await _context.SaveChangesAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditCondicion(int id, Condicion condicion)
        {
            if (id != condicion.Id_condicion)
            {
                return BadRequest();
            }

            _context.Entry(condicion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondicionExists(id))
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

        private bool CondicionExists(int id)
        {
            return _context.Condiciones.Any(e => e.Id_condicion == id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCondicion(int id)
        {
            var condicion = await _context.Condiciones.FindAsync(id);
            if (condicion == null)
            {
                return NotFound();
            }

            _context.Condiciones.Remove(condicion);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

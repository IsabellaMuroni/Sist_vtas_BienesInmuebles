using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Context;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoInmuebleController : ControllerBase
    {
        private InmuebleContext _context;

        public TipoInmuebleController(InmuebleContext context)
        {
            _context = context;
        }

        [HttpGet]
        //public IEnumerable<Cliente> GetClientes() => _context.Clientes.ToList();
        public async Task<List<Tipo_Inmueble>> GetTipoInmueblesAsync()
        {
            return await _context.Tipo_Inmuebles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_Inmueble>> GetTipoInmueble(int id)
        {
            var tipoInmueble = await _context.Tipo_Inmuebles.FindAsync(id);

            if (tipoInmueble == null)
            {
                return NotFound();
            }

            return tipoInmueble;
        }

        [HttpPost]
        public async Task CreateTipoInmueble(Tipo_Inmueble nuevoTipoInmueble)
        {
            _context.Tipo_Inmuebles.Add(nuevoTipoInmueble);
            await _context.SaveChangesAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditTipoInmueble(int id, Tipo_Inmueble tipoInmueble)
        {
            if (id != tipoInmueble.Id_tipo_inmueble)
            {
                return BadRequest();
            }

            _context.Entry(tipoInmueble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoInmuebleExists(id))
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

        private bool TipoInmuebleExists(int id)
        {
            return _context.Tipo_Inmuebles.Any(e => e.Id_tipo_inmueble == id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoInmueble(int id)
        {
            var tipoInmueble = await _context.Clientes.FindAsync(id);

            if (tipoInmueble == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(tipoInmueble);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

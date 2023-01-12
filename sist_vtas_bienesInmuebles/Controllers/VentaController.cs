using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Context;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private InmuebleContext _context;

        public VentaController(InmuebleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Venta>> GetVentasAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        [HttpPost]
        public async Task CreateVenta(Venta nuevaVenta)
        {
            _context.Ventas.Add(nuevaVenta);
            await _context.SaveChangesAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditVenta(int id, Venta venta)
        {
            if (id != venta.Id_venta)
            {
                return BadRequest();
            }

            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
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

        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(e => e.Id_venta == id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

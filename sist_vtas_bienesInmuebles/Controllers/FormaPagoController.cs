using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Context;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormaPagoController : ControllerBase
    {
        private InmuebleContext _context;

        public FormaPagoController(InmuebleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Forma_Pago>> GetFormaPagosAsync()
        {
            return await _context.Forma_Pago.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Forma_Pago>> GetFormaPago(int id)
        {
            var formaPago = await _context.Forma_Pago.FindAsync(id);

            if (formaPago == null)
            {
                return NotFound();
            }

            return formaPago;
        }

        [HttpPost]
        public async Task CreateFormaPago(Forma_Pago nuevaFormaPago)
        {
            _context.Forma_Pago.Add(nuevaFormaPago);
            await _context.SaveChangesAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditFormaPago(int id, Forma_Pago formaPago)
        {
            if (id != formaPago.Id_forma_pago)
            {
                return BadRequest();
            }

            _context.Entry(formaPago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormaPagoExists(id))
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

        private bool FormaPagoExists(int id)
        {
            return _context.Forma_Pago.Any(e => e.Id_forma_pago == id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFormaPago(int id)
        {
            var formaPago = await _context.Forma_Pago.FindAsync(id);
            if (formaPago == null)
            {
                return NotFound();
            }

            _context.Forma_Pago.Remove(formaPago);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

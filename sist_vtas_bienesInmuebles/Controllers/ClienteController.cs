using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sist_vtas_bienesInmuebles.Context;
using sist_vtas_bienesInmuebles.Models;

namespace sist_vtas_bienesInmuebles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private InmuebleContext _context;

        public ClienteController(InmuebleContext context)
        {
            _context = context;
        }

        [HttpGet]
        //public IEnumerable<Cliente> GetClientes() => _context.Clientes.ToList();
        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public async Task CreateCliente(Cliente nuevoCliente)
        {
            _context.Clientes.Add(nuevoCliente);
            await _context.SaveChangesAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id_cliente)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
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

        private bool ClienteExists (int id)
        {
            return _context.Clientes.Any(e => e.Id_cliente== id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

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

        [HttpPost]
        public async Task AddCliente(Cliente nuevoCliente)
        {
            _context.Clientes.Add(nuevoCliente);
            await _context.SaveChangesAsync();
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

        /*[HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente nuevoCliente)
        {
            if (id != nuevoCliente.Id_cliente)
            {
                return BadRequest();
            }

            _context.Entry(nuevoCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!nuevoClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<Cliente> GetClientes() => _context.Clientes.ToList();

        
    }
}

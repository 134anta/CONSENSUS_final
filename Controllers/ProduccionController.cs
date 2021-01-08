using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Consensus.Contexts;
using WebAPI_Consensus.Entities;

namespace WebAPI_Consensus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduccionController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProduccionController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProduccionDiaria>> Get()
        {
            return context.ProduccionDiaria.ToList();
        }

        [HttpGet("{id}", Name = "ObtenerProducto")]
        public ActionResult<ProduccionDiaria> Get(int id)
        {
            var producto = context.ProduccionDiaria.FirstOrDefault(x => x.idProd == id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpGet("Busqueda")] //Test buscar por Postman
        public ActionResult<ProduccionDiaria> Get([FromBody] ProduccionDiaria p)
        {
            var prodDiaria = context.ProduccionDiaria.FirstOrDefault(x => (x.produccionGenerada == p.produccionGenerada && x.fechaProd == p.fechaProd));
            if (prodDiaria == null)
            {
                return NotFound();
            }
            return prodDiaria;
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProduccionDiaria produccion)
        {
            int sumaProductos = produccion.cuadradoQty + produccion.rectanguloQty + produccion.trianguloQty + produccion.circuloQty;
            if (sumaProductos < 1000000) //Si la cantidad de figuras geometricas es menor a 1M devuelve mensaje de error
            {
                return BadRequest("La cantidad de figuras geometricas es menor a 1000000, debe ingresar una produccion total mayor a esa suma.");
            }
            context.ProduccionDiaria.Add(produccion);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerProducto", new { id = produccion.idProd}, produccion);
        }
    }
}

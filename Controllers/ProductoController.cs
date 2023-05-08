using apip.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarProductos()
        {
            List<Producto> productos = new List<Producto>{
            new Producto{
                Id = 1,
                Nombre = "Papas fuego",
                Precio = 12
            },
            new Producto{
                Id = 2,
                Nombre = "Papas azules",
                Precio = 12.50
            }
            };
            return productos;
        }

        [HttpGet]
        public dynamic clienteid(int _id)
        {
           return new Producto{
                Id = _id,
                Nombre = "Papas fuego",
                Precio = 12
            };
        }

        [HttpPost]
        [Route("agregar")]
        public dynamic guardar(Producto producto)
        {
            List<Producto> productos = listarProductos(); 
            productos.Add(producto); 
            return new
            {
                success = true,
                message = "Agregado",
                result = productos
            };
        }

    }
}

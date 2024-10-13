using Biblioteca_Parcial2.Data;
using Biblioteca_Parcial2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Parcial2.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AppDbContext repositorioProductos;
        public ProductosController(AppDbContext context)
        {
            repositorioProductos = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productos = await repositorioProductos.Productos.ToListAsync();
            return View(productos);
        }

        public async Task<IActionResult> CrearProducto(Producto producto)
        {
            if (ModelState.IsValid)
            { 
            repositorioProductos.Add(producto);
            await repositorioProductos.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }
    }
}

using Biblioteca_Parcial2.Data;
using Biblioteca_Parcial2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Parcial2.Controllers
{
    public class PedidosController : Controller
    {
        private readonly AppDbContext repositorioPedidos;
        public PedidosController(AppDbContext context)
        {
            repositorioPedidos = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productos = await repositorioPedidos.Pedidos.ToListAsync();
            return View(productos);
        }

        public async Task<IActionResult> CrearPedido(Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                repositorioPedidos.Add(pedidos);
                await repositorioPedidos.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedidos);
        }
    }
}

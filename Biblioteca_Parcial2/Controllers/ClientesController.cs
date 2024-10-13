using Biblioteca_Parcial2.Data;
using Biblioteca_Parcial2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Parcial2.Controllers
{
    public class ClientesController : Controller
    {
        private readonly AppDbContext repositorioClientes;
        public ClientesController(AppDbContext context)
        {
            repositorioClientes = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clientes = await repositorioClientes.Clientes.ToListAsync();
            return View(clientes);
        }

        public async Task<IActionResult> CrearCliente(Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                repositorioClientes.Add(clientes);
                await repositorioClientes.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }
    }
}

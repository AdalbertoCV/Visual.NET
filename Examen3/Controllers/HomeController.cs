using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Examen3.Models;
using Examen3.Data;
using Microsoft.EntityFrameworkCore;

namespace Examen3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext  _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Menu()
    {
        return View();
    }

    public async Task<IActionResult> MenuPlatillos()
    {
        return View(await _context.Platillos.ToListAsync());  
    }

    public async Task<IActionResult> MenuPostres()
    {
        return View(await _context.Postres.ToListAsync());  
    }

    public async Task<IActionResult> MenuBebidas()
    {
       return View(await _context.Bebidas.ToListAsync());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

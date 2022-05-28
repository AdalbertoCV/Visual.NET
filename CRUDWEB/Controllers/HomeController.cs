using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDWEB.Models;
using CRUDWEB.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUDWEB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index(){
            var applicationDbContext = _context.Cervezas.Include(c => c.estilo);
            return View(await applicationDbContext.ToListAsync());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

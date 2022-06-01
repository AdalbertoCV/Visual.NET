using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Examen3.Data;
using Examen3.Models;

namespace Examen3.Controllers
{
    public class PostresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PostresController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Postres
        public async Task<IActionResult> Index()
        {
              return _context.Postres != null ? 
                          View(await _context.Postres.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Postre'  is null.");
        }

        // GET: Postres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Postres == null)
            {
                return NotFound();
            }

            var postre = await _context.Postres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postre == null)
            {
                return NotFound();
            }

            return View(postre);
        }

        // GET: Postres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Postres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nombre,ingredientes,precio,urlImagen")] Postre postre)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;
                if (archivos.Count()>0){
                    string nombreArchivo = Guid.NewGuid().ToString();
                    var subidas = Path.Combine(rutaPrincipal, @"img\cartas\");
                    var extension = Path.GetExtension(archivos[0].FileName);
                    using (var fileStream = new FileStream(Path.Combine(subidas,nombreArchivo + extension), FileMode.Create)){
                        archivos[0].CopyTo(fileStream);
                    }
                    postre.urlImagen = @"img\cartas\" + nombreArchivo+ extension;
                }
                _context.Add(postre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(postre);
        }

        // GET: Postres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Postres == null)
            {
                return NotFound();
            }

            var postre = await _context.Postres.FindAsync(id);
            if (postre == null)
            {
                return NotFound();
            }
            return View(postre);
        }

        // POST: Postres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nombre,ingredientes,precio,urlImagen")] Postre postre)
        {
            if (id != postre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                string rutaPrincipal = _hostEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;
                if (archivos.Count()>0){
                    if (postre!=null && postre.urlImagen!=null){
                        var rutaImagenActual = Path.Combine(rutaPrincipal, postre.urlImagen);
                        if (System.IO.File.Exists(rutaImagenActual)){
                            System.IO.File.Delete(rutaImagenActual);
                        }
                        _context.Entry(postre).State =EntityState.Detached;
                    }
                    string nombreArchivo = Guid.NewGuid().ToString();
                    var subidas = Path.Combine(rutaPrincipal, @"img\cartas\");
                    var extension = Path.GetExtension(archivos[0].FileName);
                    using (var fileStream = new FileStream(Path.Combine(subidas,nombreArchivo + extension), FileMode.Create)){
                        archivos[0].CopyTo(fileStream);
                    }
                    postre.urlImagen = @"img\cartas\" + nombreArchivo+ extension;
                    _context.Entry(postre).State = EntityState.Modified;
                }
                _context.Update(postre);
                await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostreExists(postre.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(postre);
        }

        // GET: Postres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Postres == null)
            {
                return NotFound();
            }

            var postre = await _context.Postres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postre == null)
            {
                return NotFound();
            }

            return View(postre);
        }

        // POST: Postres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Postres == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Postre'  is null.");
            }
            var postre = await _context.Postres.FindAsync(id);
            if (postre != null)
            {
                _context.Postres.Remove(postre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostreExists(int id)
        {
          return (_context.Postres?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

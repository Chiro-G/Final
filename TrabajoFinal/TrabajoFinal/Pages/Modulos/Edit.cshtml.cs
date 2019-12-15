using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabajoFinal.Data;
using TrabajoFinal.Models;

namespace TrabajoFinal.Pages.Modulos
{
    public class EditModel : PageModel
    {
        private readonly TrabajoFinal.Data.TrabajoFinalContext _context;

        public EditModel(TrabajoFinal.Data.TrabajoFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modulo Modulo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Modulo = await _context.Modulos.FirstOrDefaultAsync(m => m.moduloID == id);

            if (Modulo == null)
            {
                return NotFound();
            }
            ViewData["cursoID"] = new SelectList(_context.Docentes, "cursoID", "Nombre");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Modulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuloExists(Modulo.moduloID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ModuloExists(int id)
        {
            return _context.Modulos.Any(e => e.moduloID == id);
        }
    }
}

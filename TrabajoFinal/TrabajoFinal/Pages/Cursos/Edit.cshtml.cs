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

namespace TrabajoFinal.Pages.Cursos
{
    public class EditModel : PageModel
    {
        private readonly TrabajoFinal.Data.TrabajoFinalContext _context;

        public EditModel(TrabajoFinal.Data.TrabajoFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curso Curso { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                
                
                return NotFound();
            }

            Curso = await _context.Cursos.FirstOrDefaultAsync(m => m.cursoID == id);

            if (Curso == null)
            {
                return NotFound();
            }

            ViewData["docenteID"] = new SelectList(_context.Docentes, "docenteID", "Nombres");
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

            _context.Attach(Curso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(Curso.cursoID))
                {
                    ViewData["docenteID"] = new SelectList(_context.Docentes, "docenteID", "Nombres");
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CursoExists(int id)
        {
            return _context.Cursos.Any(e => e.cursoID == id);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrabajoFinal.Data;
using TrabajoFinal.Models;

namespace TrabajoFinal.Pages.Pagos
{
    public class CreateModel : PageModel
    {
        private readonly TrabajoFinal.Data.TrabajoFinalContext _context;

        public CreateModel(TrabajoFinal.Data.TrabajoFinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["estudianteID"] = new SelectList(_context.Estudiantes, "estudianteID", "Nombres");
            ViewData["moduloID"] = new SelectList(_context.Estudiantes, "moduloID", "Nombre");
            return Page();
        }

        [BindProperty]
        public Pago Pago { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pagos.Add(Pago);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

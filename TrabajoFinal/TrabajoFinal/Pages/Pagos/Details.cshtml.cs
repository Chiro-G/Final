using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrabajoFinal.Data;
using TrabajoFinal.Models;

namespace TrabajoFinal.Pages.Pagos
{
    public class DetailsModel : PageModel
    {
        private readonly TrabajoFinal.Data.TrabajoFinalContext _context;

        public DetailsModel(TrabajoFinal.Data.TrabajoFinalContext context)
        {
            _context = context;
        }

        public Pago Pago { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pago = await _context.Pagos.FirstOrDefaultAsync(m => m.pagoID == id);

            if (Pago == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

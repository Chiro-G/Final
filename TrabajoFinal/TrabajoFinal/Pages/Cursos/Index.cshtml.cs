using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrabajoFinal.Data;
using TrabajoFinal.Models;

namespace TrabajoFinal.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly TrabajoFinal.Data.TrabajoFinalContext _context;

        public IndexModel(TrabajoFinal.Data.TrabajoFinalContext context)
        {
            _context = context;
        }

        public IList<Curso> Curso { get;set; }

        public async Task OnGetAsync()
        {
            Curso = await _context.Cursos.ToListAsync();
        }
    }
}

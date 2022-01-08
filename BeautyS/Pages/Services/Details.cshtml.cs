using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SalonProiect.Data;
using SalonProiect.Models;

namespace SalonProiect.Pages.Services
{
    public class DetailsModel : PageModel
    {
        private readonly SalonProiect.Data.SalonProiectContext _context;

        public DetailsModel(SalonProiect.Data.SalonProiectContext context)
        {
            _context = context;
        }

        public Service Service { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Service = await _context.Service.FirstOrDefaultAsync(m => m.ID == id);

            if (Service == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

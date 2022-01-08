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
    public class IndexModel : PageModel
    {
        private readonly SalonProiect.Data.SalonProiectContext _context;

        public IndexModel(SalonProiect.Data.SalonProiectContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; }

        public async Task OnGetAsync()
        {
            Service = await _context.Service.ToListAsync();
        }
    }
}

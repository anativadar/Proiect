using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SalonProiect.Data;
using SalonProiect.Models;

namespace SalonProiect.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly SalonProiect.Data.SalonProiectContext _context;

        public IndexModel(SalonProiect.Data.SalonProiectContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; }

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointment
                .Include(b => b.Employee)
                .Include(b => b.Service)
                .ToListAsync();
        }
    }
}

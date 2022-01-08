using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalonProiect.Data;
using SalonProiect.Models;

namespace SalonProiect.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly SalonProiect.Data.SalonProiectContext _context;

        public CreateModel(SalonProiect.Data.SalonProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Set<Employee>(), "ID", "FirstName");
            ViewData["ServiceID"] = new SelectList(_context.Set<Service>(), "ID", "Description");
            return Page();
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointment.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalonProiect.Models;

namespace SalonProiect.Data
{
    public class SalonProiectContext : DbContext
    {
        public SalonProiectContext (DbContextOptions<SalonProiectContext> options)
            : base(options)
        {
        }

        public DbSet<SalonProiect.Models.Appointment> Appointment { get; set; } //Un ENTITY set - o tabela in baza de date.

        public DbSet<SalonProiect.Models.Employee> Employee { get; set; }

        public DbSet<SalonProiect.Models.Service> Service { get; set; }
    }
}

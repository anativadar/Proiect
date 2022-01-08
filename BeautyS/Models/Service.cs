using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SalonProiect.Models
{
    public class Service
    {
        public int ID { get; set; }

        [RegularExpression(@"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$"), Required, StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }
        public ICollection<Appointment> Appointments { get; set; } //navigation property
    }
}

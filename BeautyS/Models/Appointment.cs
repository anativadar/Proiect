using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonProiect.Models
{
    public class Appointment
    {
        public int ID { get; set; }

        public int ServiceID { get; set; }
        public Service Service { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Range(1, 600)]

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

   
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}

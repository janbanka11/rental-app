using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    internal class Rental
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal RentalPrice { get; set; }
    }
}

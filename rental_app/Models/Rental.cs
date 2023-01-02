using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    internal class Rental
    {
        public string Username { get; set; }
        public int IdItem { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public decimal RentalPrice { get; set; }
    }
}

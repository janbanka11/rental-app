using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    public class RentalDTO
    {
        public RentalDTO(int rentalId, int customerId, int itemId, DateTime rentalStart, DateTime rentalEnd, decimal rentalPrice)
        {
            RentalId = rentalId;
            CustomerId = customerId;
            ItemId = itemId;
            RentalStart = rentalStart;
            RentalEnd = rentalEnd;
            RentalPrice = rentalPrice;
        }

        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public decimal RentalPrice { get; set; }
    }
}

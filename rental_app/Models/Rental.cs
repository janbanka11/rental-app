using System.ComponentModel.DataAnnotations.Schema;

namespace rental_app.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal RentalPrice { get; set; }

        public Rental(int customerId, int itemId, DateTime rentalStart, DateTime rentalEnd, decimal rentalPrice)
        {
            CustomerId = customerId;
            ItemId = itemId;
            RentalStart = rentalStart;
            RentalEnd = rentalEnd;
            RentalPrice = rentalPrice;
        }
    }
}
namespace rental_app.Models
{
    public class RentalDTO : IComparable<RentalDTO>
    {
        public RentalDTO(int rentalId, string customerName, string itemType, string itemTitle, DateTime rentalStart, DateTime rentalEnd, decimal rentalPrice)
        {
            RentalId = rentalId;
            CustomerName = customerName;
            ItemType = itemType;
            ItemTitle = itemTitle;
            RentalStart = rentalStart;
            RentalEnd = rentalEnd;
            RentalPrice = rentalPrice;
        }
        public int CompareTo(RentalDTO rentalDTO)
        {
            if (rentalDTO == null) return 1;
            return this.RentalStart.CompareTo(rentalDTO.RentalStart);
        }
        public int RentalId { get; set; }
        public string CustomerName { get; set; }
        public string ItemTitle { get; set; }
        public string ItemType { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public decimal RentalPrice { get; set; }
    }
}

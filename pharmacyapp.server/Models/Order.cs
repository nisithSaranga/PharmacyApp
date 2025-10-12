namespace pharmacyapp.server.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int DrugId { get; set; }
        public Drug? Drug { get; set; }  // Navigation property (optional)
        public int? Quantity { get; set; }         // Not nullable. An order must have a quantity!
        public string? PharmacyName { get; set; }  // Not nullable. Always required.
        public DateTime? OrderDate { get; set; }   // Not nullable. Always provided.
        public string? Status { get; set; }        // Optional but recommended: "Pending", "Completed", etc.
    }
}

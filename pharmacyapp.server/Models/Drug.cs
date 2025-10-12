namespace pharmacyapp.server.Models
{
    public class Drug
    {
        public int Id { get; set; }  // recommended non-nullable
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public decimal Price { get; set; }
    }
}




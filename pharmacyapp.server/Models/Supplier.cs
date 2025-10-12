namespace pharmacyapp.server.Models

{
    public class Supplier
    {
        public int Id { get; set; } // Primary key
        public string ? Name  { get; set; }
        public string ? Address { get; set; }
        public string ? Email { get; set; }
        public string ? Phone { get; set; }
        public string ? ContactPerson { get; set; }
    }
}

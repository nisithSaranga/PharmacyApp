namespace pharmacyapp.server.Models


{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Manager { get; set; }
        public string? Status { get; set; }
        public int? MonthlyOrders { get; set; }
        public decimal? Revenue { get; set; }
        public string? IntegrationStatus { get; set; }
    }
}

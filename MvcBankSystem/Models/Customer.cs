namespace MvcBankSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int BranchId { get; set; }
        public Branch? Branch { get; set; }
        public DateTime Birthdate { get; set; }
        public string? IdNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
    }
}

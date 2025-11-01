namespace MvcBankSystem.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public int? ManagerUserId { get; set; }
        public User? ManagerUser { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
        public List<Account> Accounts { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();

    }
}

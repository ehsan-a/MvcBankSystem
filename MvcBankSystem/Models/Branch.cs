namespace MvcBankSystem.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public int ManagerUserId { get; private set; }
        public User? ManagerUser { get; private set; }
        public string? Title { get; private set; }
        public string? Address { get; private set; }
        public string? Phone { get; private set; }
        public bool IsActive { get; private set; }
        public List<Account> Accounts { get; private set; } = new();
        public List<Customer> Customers { get; private set; } = new();

    }
}

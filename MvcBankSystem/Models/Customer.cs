namespace MvcBankSystem.Models
{
    public class Customer
    {
        public int Id { get; private set; }
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public int BranchId { get; private set; }
        public Branch? Branch { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string? IdNumber { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? Address { get; private set; }
        public bool IsActive { get; private set; }
        public Customer()
        {
            IsActive = true;
        }
    }
}

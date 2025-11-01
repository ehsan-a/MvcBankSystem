namespace MvcBankSystem.Models
{
    public class User
    {
        public int Id { get; private set; }
        public int BranchId { get; private set; }
        public Branch? Branch { get; private set; }
        public string? Username { get; private set; }
        public string? Password { get; private set; }
        public int AccountId { get; private set; }
        public Account? Account { get; private set; }
        public bool IsActive { get; private set; }
    }
}

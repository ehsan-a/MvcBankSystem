using System.ComponentModel.DataAnnotations;

namespace MvcBankSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public Branch? Branch { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int AccountId { get; set; }
        public Account? Account { get; set; }
        public bool IsActive { get; set; }
    }
}

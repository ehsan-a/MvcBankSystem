using System.ComponentModel.DataAnnotations;

namespace MvcBankSystem.Models
{
    public enum AccountType { Normal, Saving, Box }
    public class Account
    {
        public int Id { get; private set; }
        public int CustomerId { get; private set; }
        public Customer? Customer { get; private set; }
        public int CardId { get; private set; }
        public Card? Card { get; private set; }
        public int BranchId { get; private set; }
        public Branch? Branch { get; private set; }
        public string Number { get; private set; }
        public string Sheba { get; private set; }
        public bool IsActive { get; private set; }
        public AccountType Type { get; private set; }
        public DateTime? OpeningDate { get; private set; }
        public DateTime? ClosingDate { get; private set; }
        private static string s_nextAccountNumber { get; set; } = "0".PadLeft(13, '0');
        public Account()
        {
            IsActive = true;
            Number = s_nextAccountNumber = (Convert.ToInt32(s_nextAccountNumber) + 1).ToString().PadLeft(13, '0');
            Sheba = "IR808888" + Number.ToString().PadLeft(10, '0');
            OpeningDate = DateTime.Now;
        }
    }
}

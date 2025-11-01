using System.ComponentModel.DataAnnotations;

namespace MvcBankSystem.Models
{
    public enum AccountType { Normal, Saving, Box }
    public class Account
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public Card? Card { get; set; }
        public Branch? Branch { get; set; }
        public string Number { get; set; }
        public string Sheba { get; set; }
        public bool IsActive { get; set; }
        public AccountType Type { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public virtual List<Transaction> DebitTransactions { get; set; } = new();
        public virtual List<Transaction> CreditTransactions { get; set; } = new();

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

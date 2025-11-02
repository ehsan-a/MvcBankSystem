using System.ComponentModel.DataAnnotations;

namespace MvcBankSystem.Models
{
    public enum TransactionStatus { Pending, Completed, Failed }
    // public enum TransactionType { Transfer, Withdraw, Deposit }
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
        public int DebtorAccountId { get; set; }
        public Account? DebtorAccount { get; set; }
        public int CreditorAccountId { get; set; }
        public Account? CreditorAccount { get; set; }
        public TransactionStatus Status { get; set; }
        //public TransactionType Type { get; private set; }
        public Transaction()
        {
            Date = DateTime.UtcNow;
            Status = TransactionStatus.Completed;
        }
    }
}

namespace MvcBankSystem.Models
{
    public enum TransactionStatus { Pending, Completed, Failed }
    public enum TransactionType { Transfer, Withdraw, Deposit }
    public class Transaction
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
        public int DebtorAccountId { get; private set; }
        public Account DebtorAccount { get; private set; }
        public int CreditorAccountId { get; private set; }
        public Account CreditorAccount { get; private set; }
        public TransactionStatus Status { get; private set; } = TransactionStatus.Pending;
        public TransactionType Type { get; private set; }
        public Transaction()
        {
            Date = DateTime.UtcNow;
        }
    }
}

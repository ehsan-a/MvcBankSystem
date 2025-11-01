namespace MvcBankSystem.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account? Account { get; set; }
        public bool IsActive { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public int Cvv2 { get; set; }
        public int FirstPassword { get; set; }
        public int SecondPassword { get; set; }
        private static string s_nextCardNumber { get; set; } = "6037880000000000";
        public Card()
        {
            CardNumber = s_nextCardNumber = "603788" + (Convert.ToInt32(s_nextCardNumber.Substring(6, 10)) + 1).ToString().PadLeft(10, '0');
            Random random = new Random();
            Cvv2 = random.Next(100, 999);
            FirstPassword = random.Next(1000, 9999);
            SecondPassword = random.Next(10000, 99999);
            ExpDate = DateTime.Now.AddYears(10);
            IsActive = true;
        }
    }
}

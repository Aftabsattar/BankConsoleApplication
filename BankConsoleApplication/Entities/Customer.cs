namespace BankConsoleApplication.Entities;

    public class Customer
    {
        public int ID { get; set; }
        public string? Name { get; set; } =string.Empty;
        public string? Email { get; set; } =string.Empty;
        public string? Phone { get; set; } =string.Empty;
        public string? Address { get; set; } =string.Empty;
        public List<Account> Accounts { get; set; } = new List<Account>();
    }
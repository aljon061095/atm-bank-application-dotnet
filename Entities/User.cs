namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CardNumber { get; set; }

        public string SecurityPassword { get; set; }

        public decimal CurrentBalance { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
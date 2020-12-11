namespace WebApi.Models.Users
{
  public class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CardNumber { get; set; }

        public decimal CurrentBalance { get; set; }
    }
}
namespace ASP.NET_Identity.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
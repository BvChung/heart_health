namespace HeartHealthAPI.Models
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

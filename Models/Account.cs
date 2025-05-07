namespace Soccer.Models
{
    public class Account
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime UpdatedTimestamp { get; set; }

        public DateTime CreatedTimestamp { get; set; }
    }
}

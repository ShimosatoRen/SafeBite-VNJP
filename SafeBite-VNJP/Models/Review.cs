namespace SafeBite_VNJP.Models
{
    public class Review
    {
        public long Id { get; set; }

        public long RestaurantId { get; set; }

        public long UserId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; } = string.Empty;
    }
}
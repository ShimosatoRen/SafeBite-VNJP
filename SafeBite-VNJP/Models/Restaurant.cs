namespace SafeBite_VNJP.Models
{
    public class Restaurant
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
namespace SafeBite_VNJP.Models
{
    public class IngredientPost
    {
        public long Id { get; set; }

        public long RestaurantId { get; set; }

        public long UserId { get; set; }

        public string IngredientText { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;
    }
}
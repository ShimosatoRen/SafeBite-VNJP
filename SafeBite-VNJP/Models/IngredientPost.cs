namespace SafeBite_VNJP.Models
{
    /// ユーザーが投稿する食材情報
    public class IngredientPost
    {
        public long Id { get; set; }                    // 投稿ID

        public long RestaurantId { get; set; }          // どの店舗への投稿か
        public string UserId { get; set; } = string.Empty; // 投稿したユーザーID

        public string IngredientText { get; set; } = string.Empty; // 使用食材の情報
        public string? Note { get; set; }               // 補足情報（任意）

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // 投稿日時
    }
}
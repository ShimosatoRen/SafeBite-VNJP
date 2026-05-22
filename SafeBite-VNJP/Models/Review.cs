namespace SafeBite_VNJP.Models
{
    /// 店舗に対するレビュー
    public class Review
    {
        public long Id { get; set; }

        public long RestaurantId { get; set; }          // 対象店舗
        public string UserId { get; set; } = string.Empty; // 投稿者

        public int Rating { get; set; }                 // 評価（1〜5）
        public string Comment { get; set; } = string.Empty; // 感想・コメント

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
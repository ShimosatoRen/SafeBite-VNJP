namespace SafeBite_VNJP.Models
{
    /// 店舗情報を表すモデル
    public class Restaurant
    {
        public long Id { get; set; }                    // 店舗ID

        public string Name { get; set; } = string.Empty; // 店舗名（必須）
        public string Genre { get; set; } = string.Empty; // ジャンル（フォー、ブン、屋台など）
        public string? Address { get; set; }            // 住所（仮）
        public string? Description { get; set; }        // 店舗の説明（仮）
    }
}
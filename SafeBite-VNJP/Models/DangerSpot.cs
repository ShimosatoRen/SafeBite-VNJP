using System.ComponentModel.DataAnnotations;

namespace SafeBite_VNJP.Models
{
    public class DangerSpot
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Range(1, 5)]
        public int DangerLevel { get; set; }

        public string? Address { get; set; }

        public string? ImagePath { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string? UserId { get; set; }
    }
}
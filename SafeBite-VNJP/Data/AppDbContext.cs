using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeBite_VNJP.Models;

namespace SafeBite_VNJP.Data
{
    /// データベース接続とテーブル管理を行うクラス
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        // コンストラクター（接続設定を受け取る）
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // 各テーブルのDbSet（データベースのテーブルに対応）
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<IngredientPost> IngredientPosts { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
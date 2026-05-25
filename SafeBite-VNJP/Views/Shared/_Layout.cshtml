using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SafeBite_VNJP.Data;
using SafeBite_VNJP.Models;

namespace SafeBite_VNJP
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // ========================
            // データベース接続テスト + Seed
            // ========================
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                try
                {
                    var canConnect = await context.Database.CanConnectAsync();
                    Console.WriteLine(canConnect ?
                        "✅ データベース接続成功！" : "❌ 接続失敗");

                    // マイグレーション適用
                    await context.Database.MigrateAsync();
                    Console.WriteLine("✅ マイグレーション適用完了");

                    // データ投入
                    if (!await context.Restaurants.AnyAsync())
                    {
                        context.Restaurants.AddRange(
                            new Restaurant
                            {
                                Name = "フォー・ティン",
                                Genre = "フォー",
                                Address = "ホーチミン12区",
                                Description = "本場の牛肉フォー"
                            },
                            new Restaurant
                            {
                                Name = "ブン・チャー屋台",
                                Genre = "ブン",
                                Address = "ホーチミン12区",
                                Description = "グリル豚が美味しい"
                            },
                            new Restaurant
                            {
                                Name = "ナイトマーケット屋台",
                                Genre = "屋台",
                                Address = "ベンタイン市場周辺",
                                Description = "多彩なストリートフード"
                            }
                        );

                        int saved = await context.SaveChangesAsync();
                        Console.WriteLine($"✅ 初期データ {saved} 件を投入しました！");
                    }
                    else
                    {
                        Console.WriteLine("⚡ すでにデータが存在しています。");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ エラー発生: {ex.Message}");
                }
            }

            // 通常のアプリ起動処理
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
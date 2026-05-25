using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeBite_VNJP.Data;
using SafeBite_VNJP.Models;
using System.Diagnostics;
namespace SafeBite_VNJP.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // TOP
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Users
        [HttpGet("users")]
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();

            return Ok(users);
        }

        // Restaurants
        [HttpGet("restaurants")]
        public async Task<IActionResult> Restaurants()
        {
            var restaurants = await _context.Restaurants.ToListAsync();

            return Ok(restaurants);
        }

        // Reviews
        [HttpGet("reviews")]
        public async Task<IActionResult> Reviews()
        {
            var reviews = await _context.Reviews.ToListAsync();

            return Ok(reviews);
        }

        // IngredientPosts
        [HttpGet("ingredientposts")]
        public async Task<IActionResult> IngredientPosts()
        {
            var ingredientPosts = await _context.IngredientPosts.ToListAsync();

            return Ok(ingredientPosts);
        }

        // DietaryTags
        [HttpGet("dietarytags")]
        public async Task<IActionResult> DietaryTags()
        {
            var dietaryTags = await _context.DietaryTags.ToListAsync();

            return Ok(dietaryTags);
        }

        // RestaurantDietaryTags
        [HttpGet("restaurantdietarytags")]
        public async Task<IActionResult> RestaurantDietaryTags()
        {
            var restaurantDietaryTags =
                await _context.RestaurantDietaryTags.ToListAsync();

            return Ok(restaurantDietaryTags);
        }
    }
}

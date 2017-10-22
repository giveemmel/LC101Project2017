using Microsoft.EntityFrameworkCore;
using LC101Project2017.Models;

namespace LC101Project2017.Data

{  
    public class RecipeDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeCategory> Categories { get; set; }

        //public RecipeDbContext(DbContextOptions<RecipeDbContext> options)
            //: base(options)
            //{ };
    }
}

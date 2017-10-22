using LC101Project2017.Data;
using LC101Project2017.Models;
using LC101Project2017.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LC101Project2017.Controllers
{
    public class CategoryController : Controller
    {
        private readonly RecipeDbContext context;

        public CategoryController(RecipeDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<RecipeCategory> categories = context.Categories.ToList();

            return View(categories);
        }

        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();

            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                RecipeCategory newCategory = new RecipeCategory
                {
                    Name = addCategoryViewModel.Name
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();

                return Redirect("/Category");
            };

            return View(addCategoryViewModel);
        }
        


    }
}

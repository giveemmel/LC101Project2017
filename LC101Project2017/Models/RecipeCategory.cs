using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LC101Project2017.Models
{
    public class RecipeCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<RecipeCategory> RecipeCategories { get; set; }
    }
}

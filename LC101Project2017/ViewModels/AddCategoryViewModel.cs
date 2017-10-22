using System.ComponentModel.DataAnnotations;

namespace LC101Project2017.ViewModels
{
    public class AddCategoryViewModel
    {
       [Required]
       [Display(Name = "Category Name")]
       public string Name { get; set; }
    }
}

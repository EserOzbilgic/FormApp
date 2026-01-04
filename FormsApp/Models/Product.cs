using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Product Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name="Product Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name="Product Price")]
        public decimal? Price { get; set; }

        [Display(Name="Image")]
        public string? Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }
        [Display(Name="Category")]

        public int? CategoryId { get; set; }

    }
}
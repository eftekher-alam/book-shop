using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using BookShopWeb.Models;

namespace BookShopWeb.ViewModels
{
    public class BookViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required, Display(Name = "Publish Date"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime PublishDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Display(Name = "Cover Picture")]
        public IFormFile? CoverPicture { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}

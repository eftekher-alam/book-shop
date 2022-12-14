using System.ComponentModel.DataAnnotations;

namespace BookShopWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<Book>? books { get; set; }
    }
}

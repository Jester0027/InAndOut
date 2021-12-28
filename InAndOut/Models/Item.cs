using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Borrower")]
        [Required]
        public string Borrower { get; set; }

        [Display(Name = "Lender")]
        [Required]
        public string Lender { get; set; }

        [Display(Name = "Item name")]
        [Required]
        public string ItemName { get; set; }
    }
}

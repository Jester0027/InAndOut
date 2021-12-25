using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Borrower")]
        public string Borrower { get; set; }

        [Display(Name = "Lender")]
        public string Lender { get; set; }

        [Display(Name = "Item name")]
        public string ItemName { get; set; }
    }
}

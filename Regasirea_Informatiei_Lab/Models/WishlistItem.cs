using System.ComponentModel.DataAnnotations;

namespace Regasirea_Informatiei_Lab.Models
{
    public class WishlistItem
    {
        [Key]
        public int WhishlistItemId { get; set; }
        public string WhishlistId { get; set; }
        public virtual Product Produs { get; set; }
    }
}

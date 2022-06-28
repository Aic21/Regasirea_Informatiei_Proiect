using System;
using System.ComponentModel.DataAnnotations;

namespace Regasirea_Informatiei_Lab.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string ReviewMessage { get; set; }
        public int Rate { get;set; }
        public virtual Product Product { get; set; }
        public virtual User User  { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}

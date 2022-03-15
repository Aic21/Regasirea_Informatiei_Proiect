using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Models
{
    public class Product
    {
        [Key]
       public int ProductId { get; set; }
       public string ProductName { get; set; }
       public string ProductDescription { get; set; }
        public string ProductPicture { get; set; }
        public string ProductPicture2 { get; set; }
        public string ProductPicture3 { get; set; }
        public string ProductVideo { get; set; }



        public int CategoryId { get; set; }
        public int Pret { get; set; }

        public virtual Category Category { get; set; }
    }
}

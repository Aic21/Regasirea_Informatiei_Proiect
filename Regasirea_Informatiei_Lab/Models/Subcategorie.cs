using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Models
{
    public class Subcategorie
    {
        [Key]
        public int SubCategorieID { get; set; }
        public string Nume { get; set; }
        public string? Picture { get; set; }
        public virtual List<Product> Products { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Categories
        {
            get; set;
        }
    }
}
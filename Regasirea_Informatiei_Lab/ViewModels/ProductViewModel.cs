using Regasirea_Informatiei_Lab.Models;
using System.Collections.Generic;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ShortDescription { get; set; }
        public string ProductColor { get; set; }
        public string ProductPicture { get; set; }
        public string ProductPicture2 { get; set; }
        public string ProductPicture3 { get; set; }
        public string ProductVideo { get; set; }
        public string Furnizor { get; set; }
        public string TrnasportType { get; set; }
        public string DocumentPath { get; set; }
        public int Pret { get; set; }

        public double Price_after_discount { get; set; }
        public bool IsOnSale { get; set; }

        public bool IsInStock { get; set; }
        public int SubCategorieID { get; set; }
        public virtual Subcategorie Subcategorie { get; set; }
        public string CtaegoryName { get;set; }
        public string SubcategoryName { get; set; }
        public string SerialNo { get; set; }

        public int ProductStock { get; set; }

        public string Specifications { get; set; }
        public bool IsPromoted { get; set; }

        public int ReviewId { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public int AverageRating { get; set; }
    }
}

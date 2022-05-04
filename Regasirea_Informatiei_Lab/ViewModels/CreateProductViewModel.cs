using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class CreateProductViewModel 
    {
        public CreateProductViewModel()
        {
            Subcategories = new List<string>();
        }
        public List<string> Subcategories { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Photo1 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Photo2 { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Doc { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Video { get; set; }
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Pret { get; set; }
        public int Stoc { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategory { get; set; }
    }
}

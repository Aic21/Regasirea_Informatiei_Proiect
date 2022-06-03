using Microsoft.AspNetCore.Http;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class EditProductViewModel
    {
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int Pret { get; set; }
        public string Furnizor { get; set; }
        public int Stoc { get; set; }
        public int CategoryId { get; set; }
        public bool IsPromoted { get; set; }
        public Subcategorie Subcategories { get; set; }
    }
}

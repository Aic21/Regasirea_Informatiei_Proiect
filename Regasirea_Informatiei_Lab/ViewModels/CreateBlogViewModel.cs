using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class CreateBlogViewModel
    {
        [Required(ErrorMessage = "Option Name is required")]
        public string Nume { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile BlogImage { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile BlogVideo { get; set; }
        public string BlogDescription { get; set; }

    }
}

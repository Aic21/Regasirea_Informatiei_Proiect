using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class SearchListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string Search { get; set; }

    }
}

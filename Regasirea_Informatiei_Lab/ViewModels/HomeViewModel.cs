using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> Produs { get; set; }
        public IEnumerable<Category> Cat { get; set; }


    }
}

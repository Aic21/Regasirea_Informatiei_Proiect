using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Models
{
    public class Blog
    {

        public int BlogId { get; set; }

        public string BlogName { get; set; }
        public string BlogDescription { get; set; }

        public string BlogPicture { get; set; }

        public string BlogVideo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Image.Stuff.Data;

namespace MvcApplication28.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Stuff> Stuff { get; set; }
    }
}
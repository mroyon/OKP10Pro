using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAFWebAPIServices.Models
{
    public class CommonDTO
    {
        public string searchTerm { get; set; }
        public int? pageSize { get; set; }
        public int? pageNum { get; set; }
        public string param { get; set; }

        public string param1 { get; set; }

        public string param2 { get; set; }
    }
}
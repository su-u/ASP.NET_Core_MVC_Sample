using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC_Sample.Models
{
    public class Movie
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseData { get; set; }
        public String Genre { get; set; }
        public Decimal Price { get; set; }



    }
}

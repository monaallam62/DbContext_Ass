using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext_Ass.Models
{
    public  class BookInfoo
    {
        public int Id { get; set; }   
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public int PublishedYear { get; set; }
        public bool InStock { get; set; }
    }
}

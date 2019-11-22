using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FAIC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Category")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Picture")]
        public string Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
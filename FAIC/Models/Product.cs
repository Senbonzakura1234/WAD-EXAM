using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FAIC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("SupplierId")]
        public int SupplierId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual  Category Category { get; set; }

        [DisplayName("QuantityPerUnit")]
        public int QuantityPerUnit { get; set; }

        [DisplayName("UnitPrice")]
        public double UnitPrice { get; set; }

        [DisplayName("UnitsInStock")]
        public int UnitsInStock { get; set; }
        [DisplayName("UnitsOnOrder")]
        public int UnitsOnOrder { get; set; }
        [DisplayName("ReorderLevel")]
        public int ReorderLevel { get; set; }
        [DisplayName("Discontinued")]
        public int Discontinued { get; set; }
    }
}
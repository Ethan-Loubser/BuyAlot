using SQLite;
using System;

namespace BuyAlot.Models
{
    //[Table("Products")]
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ProdId { get; set; }

        [MaxLength(50), Unique]
        public string ProdName { get; set; }
        public string ProdType { get; set; }
        public string ProdPrice { get; set; }
        public string ProdImg { get; set; }
        public string ProdBrand { get; set; }
    }
}

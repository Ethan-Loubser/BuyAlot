using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using SQLite;
using SQLiteNetExtensions.Attributes;
using BuyAlot.Models;

namespace BuyAlot.Models
{
    [Table("Cartt")]
    public class Cartt
    {
        [PrimaryKey, AutoIncrement]
        public int CartId { get; set; }
        public int FAccID { get; set; }
        public string CProdName { get; set; }
        public string CProdPrice { get; set; }
        public string CProdImg { get; set; }
        public string CProdBrand { get; set; }
    }
}

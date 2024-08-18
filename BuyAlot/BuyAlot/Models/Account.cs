using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using SQLite;

namespace BuyAlot.Models
{
    [Table("Accounts")]
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int AccID { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }
        public string Email { get; set; }
        
        public string Pword { get; set; }
        public string PhoneNum { get; set; }

        public string Address { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cctype { get; set; }
        public string Ccexpiry { get; set; }
    }
}

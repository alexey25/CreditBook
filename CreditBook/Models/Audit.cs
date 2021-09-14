using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditBook.Models
{
    public class Audit
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Operation {get; set;}
        public double Amount { get; set; }
        public DateTime DataOperation { get; set; }
    }
}

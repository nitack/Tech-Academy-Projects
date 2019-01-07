using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuote.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Rate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.GoodDesign
{
    public class Invoice
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; } 

    }
}

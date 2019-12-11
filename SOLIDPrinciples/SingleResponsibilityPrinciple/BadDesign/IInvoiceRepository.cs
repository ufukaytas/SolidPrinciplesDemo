using System.Linq;

namespace SingleResponsibilityPrinciple.BadDesign
{
    public interface IInvoiceRepository
    {
        IQueryable<Invoice> Invoices { get; set; }
    }
}

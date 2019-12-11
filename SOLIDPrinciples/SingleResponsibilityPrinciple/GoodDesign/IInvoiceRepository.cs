using System.Linq;

namespace SingleResponsibilityPrinciple.GoodDesign
{
    public interface IInvoiceRepository
    {
        IQueryable<Invoice> Invoices { get; set; }
    }
}
